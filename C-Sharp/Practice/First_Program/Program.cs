using System;

namespace First_Program
{
    class Program
    {
        static void Main(string[] args)  //() is called as Panthesis
        {
            //Console.WriteLine("Hello \n World!"); // \n is used to create new line
            //                                      // Console.WriteLine is used to print the statement

            // Prgram Addition of two numbers 

            //int x, y,sum;
            //Console.WriteLine("Enter the two numbers");
            //x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());

            //sum = x + y;
            //Console.WriteLine("The sum is = "+sum);
            // Program substraction of two numbers 
            double x, y, sum;
            Console.WriteLine("Enter the two numbers");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            sum = x % y;
            Console.WriteLine("The remainder is = " + sum);

            Console.ReadLine();  // Console.ReadLine is used to latch the output screen
        }
    }
}

