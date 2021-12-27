using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, div;
            num = 30;
            num2 = 0;
            try {
                div = num / num2;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error message is: " + e.Message);
            }

        }
    }
}
