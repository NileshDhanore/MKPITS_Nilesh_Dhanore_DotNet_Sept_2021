using System;

namespace H_NOV26_Array_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.Write("cars name \n");
            foreach (string f in cars)
            {

                Console.Write(" " + f + " ");
            }
            Console.WriteLine("\nThe size of cars array is " + cars.Length);
            Array.Sort(cars);
            Console.WriteLine(" \nSorted cars are");
            foreach (string f in cars)
            {

                Console.Write(" " + f + " ");
            }
            Array.Reverse(cars);
            Console.WriteLine("\n Sorted cars in decending oreder ");
            foreach (string f in cars)
            {

                Console.Write(" " + f + " ");
            }

            Console.ReadKey();
        }
    }
    
}
