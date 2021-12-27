using System;

namespace arrayMismatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[5] { "car","animals","birds","plants","humans"};
            object[] objs = (object[])array;


            try
            {
                Object obj = (Object)13;
                objs[2] = obj;
                foreach (object Name in objs)
                {
                    System.Console.WriteLine(Name);
                }
            }
            catch(ArrayTypeMismatchException e)
            {
                Console.WriteLine("Error occured: " + e.Message);
            }
        }
    }
}
