using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This program shows how to use switch statements in C# to perform basic arithmetic operations of two number
            based on user input. */

            double num1, num2, result;

            Console.WriteLine("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            
            //This will ask the user to select an operation to perform on the two numbers.
            //They must enter 'a' for addition, 'b' for subtraction, 'c' for multiplication, or 'd' for division.
            Console.WriteLine("***************Operation Menu***************");
            Console.WriteLine("*             a. Addition                  *");
            Console.WriteLine("*             b. Subtraction               *");
            Console.WriteLine("*             c. Multiplication            *");
            Console.WriteLine("*             d. Division                  *");
            Console.WriteLine("********************************************");
            Console.WriteLine("Enter your arithmetic operation (a, b, c, d):");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                //This shows how to add two numbers if you enter 'a' as your choice.
                case 'a':
                case 'A':
                    result = num1 + num2;
                    Console.WriteLine($"The result of addition is: {result}");
                    break;

                // This shows how to subtract two numbers if you enter 'b' as your choice.
                case 'b':
                case 'B':
                    result = num1 - num2;
                    Console.WriteLine($"The result of subtraction is: {result}");
                    break;

                // This shows how to multiply two numbers if you enter 'c' as your choice.    
                case 'c':
                case 'C':
                    result = num1 * num2;
                    Console.WriteLine($"The result of multiplication is: {result}");
                    break;

                // This shows how to divide two numbers if you enter 'd' as your choice.
                case 'd':
                case 'D':
                // I use if because division by zero is always an error
                // So I check if the second number is not zero before performing the division.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"The result of division is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                // This will only shows if the user input is not one of the above choices.
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }

        }
    }
}