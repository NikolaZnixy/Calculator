using System;

class CalculatorV3
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator V3 - Enhanced");

        while (true)
        {
            Console.Write("\nEnter first number (or 'q' to quit): ");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "q") break;

            if (!double.TryParse(input1, out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            double result = 0;
            bool valid = true;
            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        valid = false;
                    }
                    else result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    valid = false;
                    break;
            }

            if (valid) Console.WriteLine($"Result: {result}");
        }

        Console.WriteLine("Calculator closed. Goodbye!");
    }
}
