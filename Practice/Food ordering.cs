using System;
using System.Collections.Generic;
 
class MenuItem
{
    public string Name;
    public double Price;
    public int Qty;
 
    public MenuItem(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
 
class Program
{
    static MenuItem[] dishes =
    {
        new MenuItem("Pizza", 150.00),
        new MenuItem("Burger", 20.00),
        new MenuItem("Cheese burger", 60.00),
        new MenuItem("Letchon manok", 250.00)
    };
 
    static MenuItem[] drinks =
    {
        new MenuItem("Sprite", 20.00),
        new MenuItem("Water", 20.00),
        new MenuItem("Cola", 20.00),
        new MenuItem("Royal", 40.00)
    };
 
    static MenuItem[] desserts =
    {
        new MenuItem("Ice Cream", 30.00),
        new MenuItem("Cassava", 60.00),
        new MenuItem("Gelatin", 20.00),
        new MenuItem("Cake", 170.00)
    };
 
    static void Main()
    {
        bool done = false;
 
        while (!done)
        {
            Console.WriteLine("----------Food Hub----------");
            Console.WriteLine("|  [a] Dish                |");
            Console.WriteLine("|  [b] Drinks              |");
            Console.WriteLine("|  [c] Dessert             |");
            Console.WriteLine("|  [d] Print Receipt       |");
            Console.Write("Choose from the menu above to order: ");
 
            string input = (Console.ReadLine() ?? "").Trim().ToLower();
            char mainOption = input.Length > 0 ? input[0] : ' ';
 
            switch (mainOption)
            {
                case 'a':
                    OrderFrom("Dish", dishes, "Select a dish: ");
                    break;
                case 'b':
                    OrderFrom("Drinks", drinks, "Select a drink: ");
                    break;
                case 'c':
                    OrderFrom("Dessert", desserts, "Select a dessert: ");
                    break;
                case 'd':
                    done = true;
                    continue;
                default:
                    Console.WriteLine("Invalid option. Please try again");
                    continue;
            }
 
            if (!AskYesNo("Do you want to order again (y/n): "))
            {
                Console.WriteLine("Printing receipt...");
                done = true;
            }
        }
 
        PrintReceipt();
        Console.WriteLine("Thank you for your order!");
    }
 
    static void OrderFrom(string title, MenuItem[] items, string prompt)
    {
        Console.WriteLine($"----------{title}----------");
        for (int i = 0; i < items.Length; i++)
            Console.WriteLine($"|  [{i + 1}] {items[i].Name,-15} Php {items[i].Price,7:F2} |");
 
        int option;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= items.Length)
                break;
            Console.WriteLine("Invalid option");
        }
 
        int qty;
        while (true)
        {
            Console.Write("Quantity: ");
            if (int.TryParse(Console.ReadLine(), out qty) && qty > 0)
                break;
            Console.WriteLine("Please enter a valid quantity.");
        }
 
        items[option - 1].Qty += qty;
    }
 
    static bool AskYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string answer = (Console.ReadLine() ?? "").Trim().ToLower();
            if (answer == "y") return true;
            if (answer == "n") return false;
            Console.WriteLine("Please enter y or n.");
        }
    }
 
    static void PrintReceipt()
    {
        var all = new List<MenuItem>();
        all.AddRange(dishes);
        all.AddRange(drinks);
        all.AddRange(desserts);
 
        double grandTotal = 0;
 
        Console.WriteLine("----------------------------------Receipt---------------------------------");
        Console.WriteLine($"{"Item(s)",-20}{"Qty",8}{"Price",15}{"Total",15}");
        Console.WriteLine();
 
        foreach (var item in all)
        {
            if (item.Qty == 0) continue;
            double total = item.Price * item.Qty;
            grandTotal += total;
            Console.WriteLine($"{item.Name,-20}{item.Qty,8}{item.Price,15:F2}{total,15:F2}");
        }
 
        Console.WriteLine();
        Console.WriteLine($"Total amount: Php {grandTotal:F2}");
        Console.WriteLine("--------------------------------------------------------------------------");
    }
}