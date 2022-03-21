using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i = 5;
            // for (; Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i--)) ;
            //   Console.ReadLine();
            int i, s = 0;
            for (i = 1; i <= 10; s = s + i, i++) ;
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();


        }
    }
}
 
