namespace Do_While;

public class DoWhile_Loop
{
    static void Main()
    {
        // Start counting at 1
        int number = 1;

        // "do" runs the code first, no checking yet
        do
        {
            Console.WriteLine($"Number: {number}");

            // Add 1 each time
            number = number + 1;

        } while (number <= 20);   // NOW it checks: repeat if number is 20 or less
                                 // Note the semicolon ; at the end. It's required!

        Console.WriteLine("Done! The number is 20");
        //BTW the difference of do while is that it will always run at least once, even if the condition is false.
        // While while loop will check the condition first before running the code, so if the condition is false, it won't run at all.
    }
}

