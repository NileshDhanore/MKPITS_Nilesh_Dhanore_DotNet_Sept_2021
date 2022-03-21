using System;

namespace Area_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Area of triangle
            const double pi = 3.14;
            int r;
            Console.WriteLine("Enter the radius of circle");
            r = Convert.ToInt32(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("The area of circle is = "+area);


        }
    }
}
