using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("----------------");

            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter an operator (+, -, *, /): ");
                    char operation = Convert.ToChar(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result;

                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: Cannot divide by zero.");
                                continue;
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid operator.");
                            continue;
                    }

                    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }

                Console.Write("Do you want to perform another calculation? (y/n): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "y") break;
            }

            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    }
}
