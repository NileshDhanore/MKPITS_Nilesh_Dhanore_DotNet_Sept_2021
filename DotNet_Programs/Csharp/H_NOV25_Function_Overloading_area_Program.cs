using System;

namespace H_NOV25_Function_Overloading_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            area(radius);
            Console.WriteLine("Enter the value of length and breadth");
            int length = Convert.ToInt32(Console.ReadLine());
            int breadth= Convert.ToInt32(Console.ReadLine());
            area(length, breadth);
            Console.WriteLine("Enter the value of base and height");
            double base_t = Convert.ToInt32(Console.ReadLine());
            int height_t = Convert.ToInt32(Console.ReadLine());
            area(base_t, height_t);

        }

        public static void area(int x)
        {
            double a = Math.PI * x * x;
            Console.WriteLine("Area of Circle is = {0:F3}" , a);
       
        }
        public static void area(int x, int y)
        {
            int a = x * y;
            Console.WriteLine("Area of rectangle is =" + a);
        }
        public static void area(double x, int y)
        {
            double a = 0.5 * x * y;
            Console.WriteLine("Area of triangle is =" + a);
        }

    }
}
