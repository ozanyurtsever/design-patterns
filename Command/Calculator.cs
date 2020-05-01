using System;

namespace Command
{
    //Receiver
    public static class Calculator
    {
        public static int Sum(int leftOperand, int rightOperand)
        {
            return leftOperand + rightOperand;
        }

        public static int Subtract(int leftOperand, int rightOperand)
        {
            return leftOperand - rightOperand;
        }

        public static int Multiply(int leftOperand, int rightOperand)
        {
            return leftOperand * rightOperand;
        }

        public static int Divide(int leftOperand, int rightOperand)
        {
            return leftOperand / rightOperand;
        }
    }
}
