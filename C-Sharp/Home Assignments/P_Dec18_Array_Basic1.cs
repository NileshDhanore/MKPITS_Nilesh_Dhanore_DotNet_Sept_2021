using System;

namespace C_Dec17_Array_Basic1
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax of array datatype [] arrayname;   [] this indicate the rank of array and the rank specifies the size of array [10] size = 10.
            

            int[] marks = new int[5];
            Console.WriteLine("Enter the Marks of Stuent ");
            for (int i = 0; i < 5; i++)
            {
                marks[i] =Convert.ToInt32(Console.ReadLine());     //ToInt32 is used to convert string into integer always write while taking input

            }
            Console.WriteLine("The NUmbers Are as Follows");
            for(int i = 0;i< 5;i++)
            {
                Console.WriteLine(marks[i]);
            }

            Console.WriteLine("---------------OR---------------");

            int[] marks = new int[5];
            marks[0] = 23;
            marks[1] = 12;
            marks[2] = 34;
            marks[3] = 45;
            marks[4] = 31;
            marks[5] = 95;
            Console.WriteLine("The marks as follows");
            foreach(int x in marks)
            {
                Console.WriteLine(x);
            }


        }
    }
}
