//using System;

//class NumbersFromOneToN
//{
//    static void Main()
//    {
//        Console.WriteLine("Please write your number: ");
//        int n = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write("{0} ", i);
//        }
//        Console.WriteLine();
//    }
//}
using System;
using System.Collections.Generic;

namespace BinaryNumbers
{
    class Program
    {
        void binaryconversion()
        {
            int n, i;
            int[] a = new int[20];
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");

            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
        static void Main(string[] args)
        {
            Program binary = new Program();
            binary.binaryconversion();
            Queue<int> number = new Queue<int>();

            number.Enqueue(1);
            number.Enqueue(2);
            number.Enqueue(3);
            number.Enqueue(4);

            //foreach (int name in number)
            //{
            //    Console.WriteLine("Elements of Queue is: " + number);
            //}

            //Console.WriteLine("Peek element: " + names.Peek());
            //Console.WriteLine("Dequeue: " + names.Dequeue());
            //Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
            //Console.ReadLine();
        }
    }
}
