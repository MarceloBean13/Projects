using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryNShop
{
    class Inventory : IPanel
    {
        public static List<Item> inventItems = new List<Item>();
        public string user;
        public void Draw()
        {
            if (inventItems.Count <= 0)
            {
                Console.WriteLine("You do not have any items yet.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"This is what you currently have     {Shop.money}$\n");
            ShowInventory();
            Console.WriteLine("\n0 - Main Menu");
            user = Console.ReadLine();
        }

        public void HandleInput()
        {
            if (inventItems.Count <= 0)
            {
                Program.panel = Program.menu;
                return;
            }
            if (string.IsNullOrEmpty(user) || !user.All(char.IsDigit))
            {
                Console.WriteLine("What now?!");
                Console.ReadLine();
                return;
            }
            int tempInven = int.Parse(user) - 1;
            if (tempInven < 0)
            {
                Program.panel = Program.menu;
                return;
            }
            if (tempInven >= inventItems.Count)
            {
                Console.Clear();
                Console.WriteLine("You don't have that item, yet.");
                return;
            }
            if (inventItems.Count >= 1)
            {
                if (inventItems[tempInven].stock == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"You have 1 item of {inventItems[tempInven].name}.");
                    Console.ReadLine();
                    return;
                }
                Console.Clear();
                Console.WriteLine($"You have {inventItems[tempInven].stock} items of {inventItems[tempInven].name}.");
                Console.ReadLine();
                return;
            }

        }
        void ShowInventory()
        {
            int count = 1;
            foreach (var item in inventItems)
            {
                Console.WriteLine($"{count} - {item.name}");
                count++;
            }
        }
    }
}
