using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("Enter the number: ");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i < 100; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not Prime.");
                   break;
                }
                else
                {
                    Console.WriteLine("Prime Number.");
                    break;
                }
            }
        }
    }
}
