using System;


namespace Command
{
    // это конкретная команда
    // (вариант - сделать отдельные команды для каждого оператора)
    public class CalculatorCommand : ICommand
    {
        private readonly Calculator _calculator;

        private readonly char _operator;
        private readonly int _operand;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void Undo()
        {
            _calculator.Operation(GetOppositeOperator(_operator), _operand);
        }

        private static char GetOppositeOperator(char @operator)
        {
            const string operators = "+-*/";
            const string opposite = "-+/*";

            var pos = operators.IndexOf(@operator);
            if (pos == -1)
            {
                throw new ArgumentException("@operator");
            }

            return opposite[pos];
        }
    }
}
