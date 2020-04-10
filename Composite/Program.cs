using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Panel panel = new Panel();
            panel.Add(new TextBox());
            panel.Add(new Label());

            panel.Draw();

            Console.ReadLine();
        }
    }
}
