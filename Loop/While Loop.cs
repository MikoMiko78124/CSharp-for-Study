using System;

class Program
{
    static void Main()
    {
        //This is a simple while loop that counts from 1 to 20
        // Start counting at 1
        int number = 1;

        // The loop keeps running WHILE number is 20 or less
       // The while loop will check if the condition is TRUE before running the code inside the loop
        while (number <= 20)
        {
            Console.WriteLine("Number: " + number);

            // Add 1 each time. Without this line, the loop never ends!
            // ++ (iteration) is shorthand for number = number + 1
            number++;
        }

        Console.WriteLine("Done!");
    }
}
