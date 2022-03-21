using System;

namespace Pattern_draw
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i=1;i<=5;i++)
            {
                for (j=5; j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
