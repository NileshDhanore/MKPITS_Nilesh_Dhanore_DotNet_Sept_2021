using System;

namespace Ascending_Order_using_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 34, 21, 34, 12, 42, 12, 121 };
            Array.Sort(num);
            Console.WriteLine("The array in Ascending order is");
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            
        }
    }
}
