using System;

namespace CustomException
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied");
            }
            else
            {
                Console.WriteLine("Access granted");
            }
        }
       public static void Main(string[] args)
        {
            try
            {
                checkAge(15);
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
