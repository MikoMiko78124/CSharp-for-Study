using System;

class ForLoopChristmasTree
{
    static void Main()
    {
        //This program prints a Christmas tree using nested for loops.
        // How many rows tall the tree is
        int height = 6;

        // OUTER loop: runs once for each row (row 1, row 2, ... row 5)
        for (int row = 1; row <= height; row++)
        {
            // FIRST inner loop: prints the empty spaces on the left.
            // The spaces push the stars toward the middle.
            // Row 1 needs 4 spaces, row 2 needs 3, and so on.
            for (int space = 1; space <= height - row; space++)
            {
                Console.Write(" ");
            }

            // SECOND inner loop: prints the stars.
            // Row 1 needs 1 star, row 2 needs 3, row 3 needs 5, and so on.
            // The formula is: (2 * row) - 1
            for (int star = 1; star <= (2 * row) - 1; star++)
            {
                Console.Write("*");
            }

            // Move to the next line after finishing the row
            Console.WriteLine();
        }
    }
}