using System;

namespace DescendingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[8]
      {
          98, 76, 99, 32, 77,90,45,123
      };
            int i, j, temp;
            Console.Write("Elements of array before sorting: ");

            for (i = 0; i < 8; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }

            for (i = 0; i < 8; i++)
            {
                for (j = i + 1; j < 8; j++)
                {
                    if (myArr[i] < myArr[j])
                    {
                        temp = myArr[i];
                        myArr[i] = myArr[j];
                        myArr[j] = temp;
                    }
                }
            }
            Console.Write("\n Elements of array after sorting: ");

            for (i = 0; i < 8; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            //Console.Write("");
        }
    }
    }

