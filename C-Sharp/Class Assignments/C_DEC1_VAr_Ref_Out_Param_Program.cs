using System;

namespace C_DEC1_VAr_Ref_Out_Param
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 200, b = 100;
            Console.WriteLine("a= "+a+"b= "+b+"before calling swap function");
            Swap(ref a, ref b);
            Console.WriteLine("a= " + a + "b= " + b + "after calling swap function");

        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
