using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    class Program
    {
        int int1, int2, sum, result;
        public Program()
        {
            int1 = 123;
            int2 = 236;
            sum = int1 + int2;
            Console.WriteLine("Sum of two number is: " + sum);
        }
        public Program(int x, int y)
        {
            result = x + y;
            Console.WriteLine("result is: " + result);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program Add = new Program(136, 567);
            Console.ReadLine();
        }
    }
}
