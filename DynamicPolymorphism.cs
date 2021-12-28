using System;

namespace DynamicPolymorphism
{
    abstract class Shape
    {
        public abstract int area();
    }
    class Rectangle: Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle area is: ");
            return (width * length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 6);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadLine();
        }
    }
}
