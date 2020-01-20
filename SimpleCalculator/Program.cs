using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNum = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNum = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNum, secondNum);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                // In a real life setting, we would want to log this message
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

