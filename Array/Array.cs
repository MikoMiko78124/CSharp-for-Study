using System;

class Program
{
    static void Main()
    {
        // Create an array that holds 6 names
        // Array are a collection of items of the same type stored in contiguous memory locations.
        // Array is zero-based, meaning the "Apple" is at index 0, the "Banana" is at index 1, and so on.
        string[] fruits = { "Apple", "Banana", "Mango", "Mama Mo", "IDK", "Wala na akong maisip" };

        // Read items by their index (position number)
        Console.WriteLine(fruits[0]);   // first item
        Console.WriteLine(fruits[1]);   // second item
        Console.WriteLine(fruits[2]);   // third item
        Console.WriteLine(fruits[3]);   // fourth item
        Console.WriteLine(fruits[4]);   // fifth item
        Console.WriteLine(fruits[5]);   // sixth item
        Console.WriteLine(fruits[6]);   // seventh item (this will throw an error because the index is out of bounds)

        // Change an item
        fruits[1] = "Orange";
        Console.WriteLine(fruits[1]);

        // Length tells us how many items are in the array
        Console.WriteLine($"Total fruits: {fruits.Length}");
    }
}