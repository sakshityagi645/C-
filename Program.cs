using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int res = 1;
            while (n != 1)
            {
                res = res * n;
                n = n - 1;
            }
            Console.WriteLine("Factorial of number is: " + res);
        }
    }
}
