using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandManager manager = new CommandManager();
            int value = 0;
            value = manager.Sum(value,2);
            value = manager.Subtract(value,1);
            value = manager.Multiply(value,6);
            value = manager.Divide(value,2);

            Console.WriteLine(value);

            value = manager.Undo();
            Console.WriteLine(value);            
        }
    }
}
