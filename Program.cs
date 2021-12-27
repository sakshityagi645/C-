using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5]{1,2,3,4,5};
            for (int i = 0; i < array.Length; i++)
            {
                if (i < 3)
                {
                    Console.WriteLine("print continue.....");
                    continue;
                }
                Console.WriteLine("Print My name is Sakshi...");
            }    
            
            //int a = 0;
            //while (a < 20)
            //{
            //    Console.WriteLine("value of a: {0}", a);
            //    a++;

            //    if (a > 15)
            //    {
            //        break;
            //    }
            //}
            //Console.ReadLine();
        }
    }
}
