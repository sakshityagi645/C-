using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my_array = new int[3, 4]
            {
                {21,45,12,65},
                {21,65,78,89},
                {65,89,99,88}
            };
            for (int i = 0; i<my_array.GetLength(0); i++)
            {
                for (int j = 0; j<my_array.GetLength(1); j++)
                {
                    Console.Write(my_array[i, j] + " ");
                }
                Console.WriteLine();
            }
           /* int[] my_array = new int[4];
            my_array[0] = 1231;
            my_array[1] = 2312;
            my_array[2] = 3212;
            my_array[3] = 4112;
            foreach(int item in my_array)
            {
                Console.WriteLine(item);
            }*/
            /*for (int i = 0; i<my_array.Length; i++)
            {
                Console.WriteLine(my_array[i]);
            }*/
        }
    }
}
