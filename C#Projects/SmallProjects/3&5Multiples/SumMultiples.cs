using System;
using System.Linq;

class SumMultiples
{
    static void Main(string[] args)
    {
        while (true)
        {
            int count = 0;
            int sum = 0;
            string user;
            Console.Clear();
            Console.Write("Please choose a number: ");
            user = Console.ReadLine();
            if (string.IsNullOrEmpty(user) || !user.All(char.IsDigit))
                continue;
            int value = int.Parse(user);
            while (count < value)
            {
                if (count % 3 == 0 || count % 5 == 0)
                    sum += count;
                count++;
            }
            Console.Clear();
            Console.WriteLine($"You chose the number {value} and the sum of all 3 and 5 multiples is {sum}");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Do you want to calculate another number? (y,n)");
            user = Console.ReadLine();
            if (user == "y")
                continue;
            else
                Environment.Exit(0);
        }
    }
}