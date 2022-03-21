using System;

namespace Fibonaccis_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0, x2 = 1,n,next_Term=0;
            Console.WriteLine("Enter the length of Fibonccis series");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Fibonaccis series is : ");
            Console.Write(x1 +" , "+x2);
            for (int i = 2; i < n; i++)
            {
                next_Term = x1 + x2;
                x1 = x2;
                x2 = next_Term;


                Console.Write(" , "+ next_Term);
            }
            Console.ReadLine();


        }
    }
}

