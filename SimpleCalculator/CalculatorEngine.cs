using System;
namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string operation, double firstNum, double secondNum)
        {
            double result;
            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "subtract":
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "multiply":
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "divide":
                case "/":
                    result = firstNum / secondNum;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");

            }
            return result;
        }
    }
}
