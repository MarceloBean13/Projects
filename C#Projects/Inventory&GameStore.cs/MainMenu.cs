using System;
using System.Linq;

namespace InventoryNShop
{
    public class MainMenu : IPanel
    {
        public string user; //Variável que recebe o input do user 
        public int temp; //Variável que vai converter para inteiro
        public void Draw()
        {
            Console.WriteLine("So, what you want to do?\n");
            Console.WriteLine("1 - Shop");
            Console.WriteLine("2 - Inventory\n");
            Console.WriteLine("\n0 - Exit");
            user = Console.ReadLine();
        }

        public void HandleInput()
        {
            if (string.IsNullOrEmpty(user) || !user.All(char.IsDigit))
            {
                Console.Clear();
                Console.WriteLine("Sorry, I can't understand what you want.\n");
                Console.ReadLine();
                return;
            }
            temp = int.Parse(user);
            if (temp <= 0)
            {
                Console.Clear();
                Console.WriteLine("See you next time!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (temp >= 3)
            {
                Console.Clear();
                Console.WriteLine($"I don't have that option man!");
                Console.ReadLine();
                return;
            }
            if (temp == 1)
            {
                Program.panel = Program.shop;
                return;
            }
            Program.panel = Program.inven;
            return;
        }
    }
}
