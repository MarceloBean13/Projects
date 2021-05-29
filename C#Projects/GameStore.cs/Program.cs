using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static int money = 800; //Giving money to the player
        static List<Item> shopItems = new List<Item>(); //Making a new list to receive Item
        static string user;
        static void mainWindow()
        {
            int temp;
            Console.WriteLine($"Hello Traveler! What can I do for you?       {money}$\n");
            while (true)
            {
                ShowItems();
                Console.WriteLine("\n0 - Exit Shop");
                user = Console.ReadLine();
                if (string.IsNullOrEmpty(user) || !user.All(char.IsDigit)) //Test if string is empty or not a digit
                {
                    Console.Clear();
                    Console.WriteLine($"What you mean?      {money}$\n");
                    continue;
                }
                temp = int.Parse(user) -1;
                if (temp > shopItems.Count())
                {
                    Console.Clear();
                    Console.WriteLine("Hey! I do not have that item!");
                    continue;
                }
                HandleInput(temp);
                Console.Clear();
                Console.WriteLine($"Thank you my friend!     ${money}\n");
            }
        }

        static void AddItems() //It will create and add the items for the shopItems list
        {
            shopItems.Add(new Item("Health Potion", 5, 100));
            shopItems.Add(new Item("Mana Potion", 5, 150));
            shopItems.Add(new Item("Skill Pendant", 3, 250));
            shopItems.Add(new Item("Hunter's Bow", 2, 375));
            shopItems.Add(new Item("Fire Katana", 2, 480));
            shopItems.Add(new Item("Diamond Shield", 1, 780));
        }

        static void ShowItems() //It will show all the items that there are currently in the list
        { 
            foreach (var item in shopItems)
            {
                Console.WriteLine(shopItems.IndexOf(item) + 1 + item.ToString());
            }
        }

        static void HandleInput(int user)
        {
            if (user < 0)
            {
                Console.Clear();
                Console.WriteLine("Bye dude have a nice day!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (money > shopItems[user].price)
            {
                if (user >= 0 && user < shopItems.Count())
                {
                    if (shopItems[user].stock > 1)
                    {
                        money -= shopItems[user].price;
                        shopItems[user].stock--;
                        return;
                    }
                    shopItems.RemoveAt(user);
                }
            }
            Console.Clear();
            Console.WriteLine("Sorry my friend not enough money! =(");
            Console.ReadLine();
            return;
        }
        static void Main(string[] args)
        {
            AddItems();
            mainWindow();
        }
    }
}
