using System;
using System.Collections.Generic;

namespace Command
{
    //Caller
    public class CommandManager
    {
        Stack<ICommand> _commands = new Stack<ICommand>();

        public int Sum(int leftOperand, int rightOperand){
            SumCommand sumCommand = new SumCommand();
            _commands.Push(sumCommand);

            return sumCommand.Execute(leftOperand, rightOperand);
        }

        public int Subtract(int leftOperand, int rightOperand){
            SubtractCommand subCommand = new SubtractCommand();
            _commands.Push(subCommand);

            return subCommand.Execute(leftOperand, rightOperand);
        }

        public int Multiply(int leftOperand, int rightOperand){
            MultiplyCommand multiplyCommand = new MultiplyCommand();
            _commands.Push(multiplyCommand);

            return multiplyCommand.Execute(leftOperand, rightOperand);
        }

        public int Divide(int leftOperand, int rightOperand){
            DivideCommand divideCommand = new DivideCommand();
            _commands.Push(divideCommand);

            return divideCommand.Execute(leftOperand, rightOperand);
        }

        public int Undo()
        {
            return _commands.Pop().Undo();
        }

        public int Undo(int times)
        {
            int _value = _commands.Pop().Undo();
            for (int i = 0; i < times - 1; ++i)
            {
                _value = _commands.Pop().Undo();
            }
            return _value;
        }


    }
}
