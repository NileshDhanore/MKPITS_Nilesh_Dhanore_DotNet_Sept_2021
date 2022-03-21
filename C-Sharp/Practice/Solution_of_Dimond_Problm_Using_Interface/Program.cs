using System;

namespace Solution_of_Dimond_Problm_Using_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            child c1 = new child();
            ((Ifather)c1).education();
            ((Imother)c1).education();

            //----------or----------------------

            Ifather c2 = new child();
            c2.education();

            Imother c3 = new child();
            c3.education();
        }
    }
    interface Ifather
    {
       //static int id;
       // static Ifather()
       // {
       //     id = 5;
       // }
        void education();
    }
    interface Imother
    {
        void education();
    }
    //class father : Ifather
    //{
    //    //public void education()
    //    //{
    //    //    //Console.WriteLine("father has master degree");
    //    //}
    //}
    //class mother :  Imother
    //{
    //    //public void education()
    //    //{
    //    //    //Console.WriteLine("mother has bacholer degree");
    //    //}
    //}
      class child: Ifather, Imother
    {
        void Ifather.education()
        {
            Console.WriteLine("father has master degree");
        }
        void Imother.education()
        {
            Console.WriteLine("mother has bacholer degree");
        }
        
    }
}
