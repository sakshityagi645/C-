using System;

namespace polymorphism
{
    class Program
    {//function overloading
        void print(int i)
        {
            Console.WriteLine("Integer number is: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Double number is: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("String number is: {0}", s);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.print(234);
            obj.print(123.43);
            obj.print("Hello Sakshi Tyagi");
            Console.ReadLine();
        }
    }
}

