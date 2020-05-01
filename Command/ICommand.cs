using System;

namespace Command
{
    public interface ICommand
    {
        int Execute(int leftOperand, int rightOperand);
        int Undo();
    }

    public class SumCommand : ICommand
    {
        private int _originalValue = 0;
        public int Execute(int leftOperand, int rightOperand)
        {
            _originalValue = leftOperand;
            return Calculator.Sum(leftOperand, rightOperand);
        }

        public int Undo()
        {
            return _originalValue;
        }
    }

    public class SubtractCommand : ICommand
    {
        private int _originalValue = 0;
        public int Execute(int leftOperand, int rightOperand)
        {
            _originalValue = leftOperand;
            return Calculator.Subtract(leftOperand, rightOperand);
        }

        public int Undo()
        {
            return _originalValue;
        }
    }

    public class MultiplyCommand : ICommand
    {
        private int _originalValue = 0;
        public int Execute(int leftOperand, int rightOperand)
        {
              _originalValue = leftOperand;
            return Calculator.Multiply(leftOperand, rightOperand);
        }

        public int Undo()
        {
            return _originalValue;
        }
    }

    public class DivideCommand : ICommand
    {
        private int _originalValue = 0;
        public int Execute(int leftOperand, int rightOperand)
        {
            _originalValue = leftOperand;
            return Calculator.Divide(leftOperand, rightOperand);
        }

        public int Undo()
        {
            return _originalValue;
        }
    }
}
