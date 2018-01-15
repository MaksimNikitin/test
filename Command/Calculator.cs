using System;

namespace Command
{
    // объект хранит целочисленное значение,
    // производит с ним арифметические операции
    // (соответствует классу Receiver на схеме)
    public class Calculator
    {
        private int _value;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    _value += operand;
                    break;
                case '-':
                    _value -= operand;
                    break;
                case '*':
                    _value *= operand;
                    break;
                case '/':
                    _value /= operand;
                    break;
            }
            Console.WriteLine("Current value = {0,1}", _value);
        }
    }
}
