using System;

namespace IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(array[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error message is: " + e.Message);
            }
        }
    }
}
