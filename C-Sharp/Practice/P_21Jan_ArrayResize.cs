using System;
using System.Collections;

namespace P_21Jan_ArrayResize
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList al = new ArrayList(); // ArrayList(2);capacity start from 2
            Console.WriteLine(al.Capacity);
            al.Add(20);
            Console.WriteLine(al.Capacity);    // it will take 4 byte of memory
            al.Add(30); al.Add(40); al.Add(50);
            Console.WriteLine(al.Capacity);
            al.Add(60);
            Console.WriteLine(al.Capacity);

            foreach (object obj in al)
            
                Console.Write(obj+" ");
                Console.WriteLine();
            

            Console.WriteLine("----------------------------------------");

            al.Insert(3, 35);
            foreach (object obj in al)
            
                Console.Write(obj + " ");
                Console.WriteLine();
            

            al.Remove(30);
            foreach (object obj in al)
            
                Console.Write(obj + " ");
                Console.WriteLine();
            
            Console.ReadKey();


        }
    }
}
//int[] ary = { 28, 33 };

//int[] p1 = new int[20] ;
//p1[0] = 2;
//p1[1] = 3;


//foreach(int temp in ary)
//{
//    Console.WriteLine(temp);
//}
//foreach (int temp in p1)
//{
//    Console.WriteLine(temp);
//}