using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IObserver
    {
        void Update(int value);
    }

    public class TextBox : IObserver
    {
        public string Text { private get; set; }
        public void Update(int value)
        {
            Text = value.ToString();
            Console.WriteLine($"{nameof(TextBox)} is reacted to the change. {nameof(Text)} is changed to {Text}");
        }
    }

    public class CheckBox : IObserver
    {
        public bool IsChecked { private get; set; }
        public void Update(int value)
        {
            IsChecked = value % 2 == 0 ? true : false;
            Console.WriteLine($"{nameof(CheckBox)} is reacted to the change. {nameof(IsChecked)} is changed to {IsChecked}");
        }
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class TrackBar : ISubject
    {
        private List<IObserver> _Observers { get; set; } = new List<IObserver>();
        private int _Value { get; set; }
        public void Attach(IObserver observer)
        {
            _Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in _Observers)
            {
                item.Update(_Value);
            }
        }

        public void UpdateBar(int value)
        {
            _Value = value;
            Notify();
        }
    }




}
