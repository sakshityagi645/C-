using System;

namespace MaximumMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8] { 12,34,64,21,100,45,1,7};
            int max, min;
            max = array[0];
            min = array[0];
            for (int i = 0; i < array.GetLength(0); i++) {
                if (array[i] > max)
                { 
                    max = array[i]; 
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Maximum element is : " + max);
            Console.WriteLine("Minimum element is : " + min);
        }
    }
}
