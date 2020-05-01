using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TrackBar trackBar = new TrackBar();
            List<IObserver> observers = new List<IObserver> { new TextBox(), new CheckBox() };
            foreach (var item in observers)
            {
                trackBar.Attach(item);
            }

            trackBar.UpdateBar(100);
            Console.WriteLine("------------------------------------");
            trackBar.UpdateBar(201);
            Console.WriteLine("------------------------------------");
            trackBar.UpdateBar(320);
        }
    }
}
