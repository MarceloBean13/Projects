using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryNShop
{
    public class Shop : IPanel
    {
        public string user;
        public int temp;
        public static int money = 1000;
        public List<Item> shopItems = new List<Item>();
        public void Draw()
        {
            if (shopItems.Count >= 1)
            {
                Console.WriteLine($"Welcome to my shop! Which item do you choose?        {money}$\n");
                ShowItems();
                Console.WriteLine("\n0 - Main Menu");
                user = Console.ReadLine();
                return;
            }
        }

        public void HandleInput()
        {
            if (shopItems.Count >= 1)
            {
                if (string.IsNullOrEmpty(user) || !user.All(char.IsDigit))
                {
                    Console.Clear();
                    Console.WriteLine("What is it you want with that?");
                    Console.ReadLine();
                    return;
                }
                temp = int.Parse(user) - 1;
                if (temp >= shopItems.Count)
                {
                    Console.Clear();
                    Console.WriteLine("Hum... I don't have that item.");
                    Console.ReadLine();
                    return;
                }
                if (temp < 0)
                {
                    Program.panel = Program.menu;
                    return;
                }
                if (money >= shopItems[temp].price)
                {
                    if (shopItems[temp].stock > 1)
                    {
                        shopItems[temp].stock--;
                        money -= shopItems[temp].price;
                        if (!Inventory.inventItems.Any(n => n.name == shopItems[temp].name))
                            Inventory.inventItems.Add(new Item(shopItems[temp].name, 1, 1));
                        else
                        {
                            foreach (var item in Inventory.inventItems.Where(n => n.name == shopItems[temp].name))
                                item.stock++;
                        }
                        Console.Clear();
                        Console.WriteLine("Thank you for your purchase!");
                        Console.ReadLine();
                        return;
                    }
                    if (shopItems[temp].stock == 1)
                    {
                        money -= shopItems[temp].price;
                        foreach (var item in Inventory.inventItems.Where(n => n.name == shopItems[temp].name))
                            item.stock++;
                        shopItems.RemoveAt(temp);
                        return;
                    }
                }
                Console.Clear();
                Console.WriteLine("What?! NO MONEY?!?");
                Console.ReadLine();
                return;
            }
            if (shopItems.Count == 0)
            {
                Console.WriteLine("You have bought all my items for now! =)");
                Console.ReadLine();
                Program.panel = Program.menu;
                return;
            }
        }

        void ShowItems()
        {
            foreach (var item in shopItems)
            {
                Console.WriteLine($"{shopItems.IndexOf(item) + 1 + item.ToString()}");
            }
        }
        public void CreateItems()
        {
            shopItems.Add(new Item("Health Potion", 5, 50));
            shopItems.Add(new Item("Mana Potion", 6, 75));
        }
    }
}
