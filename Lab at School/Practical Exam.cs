using System;

namespace ConsoleApp1;

class  Program
{
    static void Main(string[] args)
    {
        double a, b, sum, difference, product, quotient, modulus;
        string name = "Mark Angelo Mercado";
        //Part A - Arithmetic Operators
        Console.WriteLine("***************Part A - Arithmetic Operators***********************\n");

        Console.WriteLine($"{name}\n");

        // Prompt the user to input two numbers
        Console.WriteLine("Input the first number: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input the second number: ");
        b = Convert.ToDouble(Console.ReadLine());

        // Calculate the sum of two numbers
        sum = a + b;

        // Display the result of sum
        Console.WriteLine($"\nThe sum of the two numbers is: {sum}");

        // Calculate the difference of two numbers
        difference = a - b;
        
        // Display the result of two numbers  
        Console.WriteLine($"The difference of the two numbers is: {difference} ");

        // Calculate the product of two numbers
        product = a * b;

        // Display the result of product
        Console.WriteLine($"The product of the two numbers is: {product} ");

        // Calculate the quotient of two numbers
        quotient = a / b;
        
        // Display the result of quotient 
        Console.WriteLine($"The quotient of the two numbers is: {quotient} ");

        // Calculate the modulus of two numbers
        modulus = a % b;
        
        // Display the result of two numbers  
        Console.WriteLine($"The modulus of the two numbers is: {modulus} ");

        Console.WriteLine("\n*************************************************************\n");

        //Part B - Relational Operator
        Console.WriteLine("****************Part B - Relational Operators*******************\n");
        
        //Display if a is greater than b
        Console.WriteLine($"The {a} is greater than {b}: " + (a > b));

        //Display if a is less than b
        Console.WriteLine($"The {a} is less than {b}: " + (a < b));

        //Display if a is equal to b
        Console.WriteLine($"The {a} is equal to {b}: " + (a == b));

        //Display if a is greater than or equal to b
        Console.WriteLine($"The {a} is greater than or equal to {b}: " + (a >= b));

        //Display if a is less than or equal to b
        Console.WriteLine($"The {a} is less than or equal to {b}: " + (a <= b));

        //Display if a is not equal to b
        Console.WriteLine($"The {a} is not equal to {b}: " + (a != b));
        Console.WriteLine("\n*****************************************************************\n");

        //Part C - Assignment Operator
        Console.WriteLine("\n****************Part C - Assignment Operators******************\n");

        // Add and assign by 20
        sum += 20;

        // Display the result of sum if add and assign by 20
        Console.WriteLine($"The result of sum if add and assign by 20 is: {sum}");

        // Subtract and assign by 20
        difference -= 20;

        // Display the result of difference if subtract and assign by 20
        Console.WriteLine($"The result of difference if subtract and assign by 20 is: {difference}");

        // Multiply and assign by 5
        product *= 20;

        // Display the result of product if multiply and assign by 5
        Console.WriteLine($"The result of product if multiply and assign by 20 is: {product}");

        // Divide and assign by 2
        quotient /= 2;

        // Display the result of quotient if divide and assign by 2
        Console.WriteLine($"The result of quotient if divide and assign by 2 is: {quotient}");

        // Modulo and assign by 3
        modulus %= 3;

        // Display the result of modulus if modulo and assign by 2
        Console.WriteLine($"The result of modulus if modulo and assign by 3 is: {modulus}");

        Console.WriteLine("\n**************************************************************\n");

        // Display the programmer who create the program
        Console.WriteLine($"Made by {name}");
        Console.ReadLine();
    }
}