using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IComponent
    {
        void Draw();
        void Add(IComponent component);
        void Remove(IComponent component);
    }

    public class Label : IComponent
    {
        public void Draw()
        {
            Console.WriteLine($"This is a {nameof(Label)}");
        }

        public void Add(IComponent component)
        {
            throw new NotSupportedException();
        }

        public void Remove(IComponent component)
        {
            throw new NotSupportedException();
        }
    }

    public class TextBox : IComponent
    {
        public void Draw()
        {
            Console.WriteLine($"This is a {nameof(TextBox)}");
        }
        public void Add(IComponent component)
        {
            throw new NotSupportedException();
        }
        public void Remove(IComponent component)
        {
            throw new NotSupportedException();

        }
    }

    public class Panel : IComponent
    {
        public List<IComponent> Components { get; set; }

        public Panel()
        {
            Components = new List<IComponent>();
        }

        public void Draw()
        {
            Console.WriteLine($"This is a {nameof(Panel)}");

            Console.WriteLine("Child Components:");
            Console.WriteLine("-------------------------------------");
            foreach ( var item in Components)
            {
                item.Draw();
            }
        }
        public void Add(IComponent component)
        {
            Components.Add(component);
        }
        public void Remove(IComponent component)
        {
            Components.Remove(component);

        }
    }
}
