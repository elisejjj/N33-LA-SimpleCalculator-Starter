using System;
using System.Text;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double calculatorOn = 1;
            while (calculatorOn != 2)
            {



                try
                {
                    // Class to convert user input
                    InputConverter inputConverter = new InputConverter();

                    // Class to perform actual calculations
                    CalculatorEngine calculatorEngine = new CalculatorEngine();

                    Console.WriteLine("Write the first number:");

                    double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine("Write the second number:");
                    double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine("Write the operation (+, -, /, *):");
                    string operation = Console.ReadLine();

                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        Console.WriteLine("Invalid operator. Type in +, -, /, or * without any spaces or extra characters.");
                        operation = Console.ReadLine();
                    }

                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                    StringBuilder finalMessage = new StringBuilder("The value ");
                    finalMessage.Append(firstNumber.ToString());
                    finalMessage.Append(" ");
                    finalMessage.Append(operation.ToString());
                    finalMessage.Append(" the value ");
                    finalMessage.Append(secondNumber.ToString());
                    finalMessage.Append(" is equal to ");
                    finalMessage.Append(result.ToString("F2"));

                    Console.WriteLine(finalMessage.ToString());

                    Console.WriteLine("Enter 1 to do another calculation, or 2 to close the calculator");
                    calculatorOn = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    // Normally, we'd log this error to a file.
                    Console.WriteLine("Invalid input. Please input a single number without any spaces or extra characters.");
                }
                 
            }
        }
    }
}
