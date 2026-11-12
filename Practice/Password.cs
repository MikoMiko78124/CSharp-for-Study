using System;

    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            string password = "ILOVECODING";
            string name;

            Console.WriteLine("Enter you name: ");
            name = Console.ReadLine();
            
            while(i > 0)
            {
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();

                i--;
                Console.WriteLine("You have " + i + " attempts left.");
                
                if(password == "ILOVECODING")
                {
                    Console.WriteLine("Welcome " + name + "!");
                
                }
                else if(i == 0)
                {
                    Console.WriteLine("You have no attempts left. Please try again later.");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Please try again.");
                }
            }
    }
}