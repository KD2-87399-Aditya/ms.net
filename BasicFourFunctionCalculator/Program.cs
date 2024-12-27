using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasicFourFunctionCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter + to add numbers");
            Console.WriteLine("Enter - to subtract numbers");
            Console.WriteLine("Enter * to multiply numbers");
            Console.WriteLine("Enter / to divide numbers");
            char operation = Console.ReadLine()[0];
            Console.WriteLine("Enter number 1");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            double num2 = double.Parse(Console.ReadLine());

            double result;
            switch(operation)
            {

                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;


            };
            
            
        }
    }
}
