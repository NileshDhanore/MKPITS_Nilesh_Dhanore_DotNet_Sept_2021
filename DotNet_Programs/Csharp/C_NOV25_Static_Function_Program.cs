using System;

namespace C_NOV25_Static_Function
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //double a = Area_Circle(2);
        //    //Console.WriteLine("The area of circle= {0:F2}", a);
        //    //Console.ReadKey();
        //}
        //public static double Area_Circle(int r)
        //{
        //    return Math.PI * r * r;
        //}

        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            Area_Circle(radius);
            Area_Circle(7);
            Console.ReadLine();
        
        }
        public static void Area_Circle(int r)
        {
            double a = Math.PI * r * r;
            Console.WriteLine("The area of circle is= {0:F3}",a);
        }
    }
}
