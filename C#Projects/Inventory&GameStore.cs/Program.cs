using System;

namespace InventoryNShop
{
    class Program
    {
        //Aqui é preciso instânciar todas as classes necessárias para o programa
        public static MainMenu menu = new MainMenu();
        public static Inventory inven = new Inventory(); 
        public static Shop shop = new Shop();
        public static IPanel panel;
        static void Main(string[] args)
        {
            shop.CreateItems(); //Colocar os itens na lista criada na classe Shop
            panel = menu; //A primeira classe a correr é o Menu
            while (true)
            {
                Console.Clear();
                panel.Draw();
                panel.HandleInput();
            }
        }
    }
}
