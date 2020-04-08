using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            MessengerManager manager = new MessengerManager();
            manager.Forward("You've earned 100$ credit.");

            Console.ReadLine();
        }
    }
}
