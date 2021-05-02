using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        //Criar uma lista que vai receber todos os objectos Item
        static List<Item> UserItem = new List<Item>();
        //Criar um contador
        static int count;
        //Criar items dentro da classe objecto Item
        static Item Item1 = new Item("          Shortcake", 3, 50);
        static Item Item2 = new Item("     French Muffins", 4, 80);
        static Item Item3 = new Item("     Great Stallion", 2, 350);
        static Item Item4 = new Item(" Beautiful Long Bow", 1, 500);
        static Item Item5 = new Item("Zeus Lightning Bolt", 1, 999);

        static void Main(string[] args)
        {
            PutinList();
            FirstShop();
        }
        //Função que coloca a quantidade de items na lista
        static void PutinList()
        {
            UserItem.Add(Item1);
            UserItem.Add(Item2);
            UserItem.Add(Item3);
            UserItem.Add(Item4);
            UserItem.Add(Item5);
        }
        //Função que mostra e actualiza o Shop
        static int ShowShop()
        {
            count = 0;
            //Variável que vai ser o que o user terá que escolher
            int num = count + 1;         
            //Enquanto o contador for menor que o número de itens na lista
            while (count < UserItem.Count)
            {
                //Escreve a variável que o user terá que escolher e todos os itens que existem na lista actualmente
                Console.WriteLine($"{num} {UserItem[count]}");
                count++;
                num++;
            }
            //Vai retornar um inteiro que a função UpdateShop recebe para actualizar os dados da lista de itens
            return (count);
        }
        //Função que actualiza os items consoante o input do user
        static void UpdateShop(int user)
        {
            if (user <= count)
            {
                if (UserItem[user - 1].stock > 1)
                    UserItem[user - 1].stock -= 1;
                else
                    UserItem.RemoveAt(user - 1);
            }
        }
        //Função que vai criar uma nova loja
        static void NewShop(int user)
        {
            int temp;
            //Se o input for positivo
            if (user <= count && user > 0)
            {
                //Se houver itens na loja
                if (UserItem.Count >= 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for your purchase!\n");
                    ShowShop();
                    var newuser = Console.ReadLine();
                    //Dar continuação à loja caso haja itens na loja
                    if (int.TryParse(newuser, out temp))
                    {
                        UpdateShop(temp);
                        NewShop(temp);
                    }
                    //Caso não seja inteiro
                    else
                        NewShop(0);
                }
                //Já não há itens na loja
                else
                {
                    Console.Clear();
                    Console.WriteLine("You've purchased everything!! Thank you very much =)");
                    Console.ReadLine();
                }
            }
            //Se o input for um inteiro que não existe na loja
            else if (user > count)
            {
                Console.Clear();
                Console.WriteLine("I do not have that one! Please, choose one that I have.\n");
                ShowShop();
                var newuser = Console.ReadLine();
                if (int.TryParse(newuser, out temp))
                {
                    UpdateShop(temp);
                    NewShop(temp);
                }
                else
                    NewShop(0);
            }
            //Caso o input não seja um número inteiro
            else if (user == 0)
            {
                Console.Clear();
                Console.WriteLine("Could you choose a item this time please?\n");
                ShowShop();
                var newuser = Console.ReadLine();
                if (int.TryParse(newuser, out temp) && temp > 0)
                {
                    UpdateShop(temp);
                    NewShop(temp);
                }
                else
                    NewShop(0);
            }
        }
        //Mostrar o shop pela primeira vez
        static void FirstShop()
        {
            int temp;

            Console.WriteLine("Welcome Adventurer!! What you're buying?\n");
            ShowShop();
            //Variável que recebe qualquer valor do user
            var user = Console.ReadLine();
            //Aqui irá testar se o user escreve um inteiro ou não
             if (int.TryParse(user, out temp) && temp > 0)
            {
                UpdateShop(temp);
                NewShop(temp);
            }
            else
                NewShop(0);
        }
    }
}
