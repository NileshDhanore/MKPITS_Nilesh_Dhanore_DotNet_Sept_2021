using System;

namespace C_NOV_Funtion_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Sum(a, b, c);
            Sum(2, 3, 4);
            Sum(12, 13);
        }
        public static void Sum(int a,int b,int c) 
        {
            int s = a + b + c;
            Console.WriteLine("Sum of three numbers" +s);
        }
        public static void Sum(int a, int b)
        {
            int s = a + b;
            Console.WriteLine("Sum of three numbers" + s);
        }
        
    }
}
