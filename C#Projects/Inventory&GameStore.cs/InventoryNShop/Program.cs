using System;
using System.Collections.Generic;
    
namespace InventoryNShop
{
    class Program
    {
        //Begin by creating a list to receive the items for the shop
        static List<Item> ItensShop = new List<Item>();

        //The main method where we will start by adding our items to the list
        //and showing the Main Menu to the user
        static void Main(string[] args)
        {
            CreateItems();
            MainMenu();
        }
        //Create a funtion that creates the items and adds them to the list
        static void CreateItems()
        {
            Item item1 = new Item("         Bandage", 9, 50);
            Item item2 = new Item("   Skill Bandaid", 7, 100);
            Item item3 = new Item("Domestic Handgun", 2, 245);

            ItensShop.Add(item1);
            ItensShop.Add(item2);
            ItensShop.Add(item3);
        } 
        
        //Create a Main Menu for the user to choose the available options
        static void MainMenu()
        {
            string user;

            Console.Clear();
            Console.WriteLine("Main Menu:\n\n1 - Inventory\n2 - Items Shop\n\n0 - Exit Main Menu");
            user = Console.ReadLine();
            if (user == "1")
                ShowInv();
            else if (user == "2")
            {
                if (ItensShop.Count >= 1)
                    FirstShop();
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have purchased everything. Thank you.");
                    Console.ReadLine();
                    MainMenu();
                }
            }
            else if (user == "0")
                Environment.Exit(0);
            else
            {
                Console.Clear();
                MainMenu();

            }
        }
        //The function that shows what the user currently has in his inventory
        static void ShowInv()
        {
            string user;

            Console.Clear();
            Console.WriteLine("Your Inventory\n\nCurrent Items:");
            Console.WriteLine("\n0 - Return to Main Menu");
            user = Console.ReadLine();
            if (user == "0")
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Clear();
                ShowInv();
            }
        }
        //Funtion that will show all the current items
        static void ShowItems()
        {
            int ind = 1;
            foreach (var item in ItensShop)
            {
                Console.WriteLine($"{ind} {item.name} - {item.price}$ x{item.stock}");
                ind++;
            }
        }
        
        //Shop for the user to buy items
        static void FirstShop()
        {
            int i;
            Console.Clear();
            Console.WriteLine("Welcome to my shop! What will it be?\n");
            ShowItems();
            Console.WriteLine("\n0 - Go back to Main Menu");
            var user = Console.ReadLine();
            if (user == "0")
            {
                Console.Clear();
                MainMenu();
            }
            else if (int.TryParse(user, out i))
                UpdateShop(i);
            else
                FirstShop();
        }

        //Function that updates the shop based on the input of the user
        static void UpdateShop(int user)
        {
            while (ItensShop.Count >= 1)
            {
                if (user > 0 && user <= ItensShop.Count)
                {
                    if (ItensShop[user - 1].stock > 1)
                    {
                        ItensShop[user - 1].stock -= 1;
                        Console.Clear();
                        Console.WriteLine("Thank you for your purchase!\n");
                        NewShop();
                    }
                    else
                    {
                        ItensShop.RemoveAt(user - 1);
                        Console.Clear();
                        Console.WriteLine("Thank you for your purchase!\n");
                        NewShop();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("I do not have that item!\n");
                    NewShop();
                }
            }
            if (ItensShop.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("You have purchased everything. Thank you.");
                MainMenu();
            }
        }
        
        //Function that gives a new shop to the user
        static void NewShop()
        {
            int i;
            ShowItems();
            Console.WriteLine("\n0 - Go back to Main Menu");
            var user = Console.ReadLine();
            if (user == "0")
            {
                Console.Clear();
                MainMenu();
            }
            else if (int.TryParse(user, out i))
                UpdateShop(i);
            else if (ItensShop.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("You have purchased everything. Thank you.");
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Choose one item I have please.\n");
                NewShop();
            }
        }
    }
}
