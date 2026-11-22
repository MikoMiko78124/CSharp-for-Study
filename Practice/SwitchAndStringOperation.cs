using System;

namespace stringAndswitch;

class Practice
{
    static void Main(string[] args)
    {
        int operation;

        Console.WriteLine("Please enter a string: ");
        string word = Console.ReadLine();

        do
        {
        Console.WriteLine("\n=======Select an Operation======");
        Console.WriteLine("[1] Convert to Uppercase ");
        Console.WriteLine("[2] Convert to Lowercase ");
        Console.WriteLine("[3] Count Characters ");
        Console.WriteLine("[4] Extract a Substring ");
        Console.WriteLine("[5] Replace a Word");
        Console.WriteLine("[6] Search for a Word ");
        Console.WriteLine("[7] Split the Sentence ");
        Console.WriteLine("[8] Remove Extra Spaces ");
        Console.WriteLine("[9] Exit ");
        Console.WriteLine("==================================");
        Console.WriteLine("Enter your Choice: ");
        operation = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine($"This is your word Uppercase: {word.ToUpper()}");
                break;

            case 2:
                Console.WriteLine($"This is your word Uppercase: {word.ToLower()}");
                break;

            case 3:
                Console.WriteLine($"This how many your letter your word is: {word.Length}");
                break;

            case 4:
                bool error = false;

                do
                {
                    try
                    {
                        Console.WriteLine("Enter the index of the substring: ");
                        int sg_index = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the length of the substring: ");
                        int sg_length = int.Parse(Console.ReadLine());
                
                        Console.WriteLine($"This is the substring: {word.Substring(sg_index,sg_length)}");
                        error = true;
                    
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error, {ex.Message} Try again");
                    }
                } while(!error);
                break;

            case 5:
                bool success = false;
                do
                {
                    try{
                
                        Console.WriteLine("Enter the word to replace: ");
                        string word_replace = Console.ReadLine();

                        Console.WriteLine("Enter replacement word: ");
                        string new_word = Console.ReadLine();

                        string replaced = word.Replace(word_replace,new_word);

                        Console.WriteLine($"This is result: {replaced}");
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error, {ex.Message} Try again");
                    } 
                } while (!success);
                break;

            case 6:
                bool success2 = false;
                do
                {
                    try
                    {
                        Console.WriteLine("Please enter a word to search:");
                        string search = Console.ReadLine();

                        int indexing= word.IndexOf(search);

                        if (indexing == -1)
                            {
                                Console.WriteLine("Error!!!\nPlease Try Again\n");
                            }
                        else
                            {
                                Console.WriteLine($"This is index of the word {word.IndexOf(search)}");
                                success2 = true;
                            }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error, {ex.Message} Try again");
                    }
                }while(!success2);
                break;
                
            case 7:

                string[] split = word.Split(' ');
                foreach (string many in split)
                {
                        Console.WriteLine($"This is the words splitted: {many}");
                }
                break;
            
            case 8:
            
                Console.WriteLine($"This the result of removing spaces: {word.Replace(" ","")}");
                break;

            case 9:

                Console.WriteLine("Thank you for using the program!!!");
                break;
            default:

                Console.WriteLine("Error!!!\nPlease try again");
                break;
        } 
        } while (operation != 9);
    }
}