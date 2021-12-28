using System;

namespace Method_Overloading
{
    class Program
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public static void Main(string[] args)
        {
            Program obj = new Program();
            int sum1 = obj.Add(123, 542);
            Console.WriteLine(sum1);

            int sum2 = obj.Add(143, 562, 543);
            Console.WriteLine(sum2);
            Console.ReadLine();
        }
    }
}
