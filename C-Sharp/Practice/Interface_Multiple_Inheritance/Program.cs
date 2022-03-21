using System;

namespace Interface_Multiple_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ary = { 2, 3, 4 };
            //Console.WriteLine(ary[0]);
            Child C1 = new Child();
            C1.A();
            C1.B();

        }
    }
    interface Ifather
    {
        public void A();
        
    }
    interface IMother
    {
        public void B();
    }
    class Child:Ifather,IMother
    {
        public void A()
        {
            Console.WriteLine("I am Father");
        }
        public void B()
        {
            Console.WriteLine("I am Mother");
        }
    }
}
