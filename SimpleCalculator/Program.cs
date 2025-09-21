using CalculatorEngineName;
using System;
using System.Globalization;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;

namespace SimpleCalculator
{
    class Programa
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            double calculatorOn = 1;
            while (calculatorOn != 2)
            {



                try
                {
                    // Class to convert user input
                    InputConverter inputConverter = new InputConverter();

                    // Class to perform actual calculations
                    CalculatorEngine calculatorEngine = new CalculatorEngine();

                    Console.WriteLine(Constants.FirstNumberPrompt);

                    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine(Constants.SeconNumberPrompt);
                    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine(Constants.OperatorPrompt);
                    string operation = Console.ReadLine();

                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        Console.WriteLine(Constants.InvalidOperator);
                        operation = Console.ReadLine();
                    }

                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                    StringBuilder finalMessage = new StringBuilder(Constants.TheValue);
                    finalMessage.Append(firstNumber.ToString());
                    finalMessage.Append(Constants.Space);
                    finalMessage.Append(operation.ToString());
                    finalMessage.Append(Constants.TheValue);
                    finalMessage.Append(secondNumber.ToString());
                    finalMessage.Append(Constants.IsEqualTo);
                    finalMessage.Append(result.ToString("F2"));

                    Console.WriteLine(finalMessage.ToString());

                    Console.WriteLine(Constants.PromptRepeater);
                    calculatorOn = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    // Normally, we'd log this error to a file.
                    Console.WriteLine(Constants.InvalidNumber);
                }
                 
            }
        }
    }
}
