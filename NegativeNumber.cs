using System;

namespace NegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7]
            {
                12,2,-2,45,-45,-76,58
            };
            for (int i = 0; i < array.GetLength(0); i++)
            {

                if (array[i] < 0)
                {
                   Console.WriteLine("Negative numbers in array is: " + " " + array[i]);
                }
            }          
        }
    }
 }
