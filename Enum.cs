using System;

namespace Enum
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Low;
            Console.WriteLine(myVar);
        }
    }
}
