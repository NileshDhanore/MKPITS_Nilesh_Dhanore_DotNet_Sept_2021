using System;

namespace p_Delegate_Example
{
    public delegate void AddDelegagte(int x, int y);
    public delegate string SayDelegate(string name);
    class Program
    {
        public void AddSum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello : " + name;
        }
        static void Main(string[] args)
        {
            //without delegate
            Program P = new Program();
            //P.AddSum(100, 20);
            //string str=SayHello("Nilesh"); // As method is static dont need to make instance like P.AddSum
            //Console.WriteLine(str);

            //with delegate

            AddDelegagte ad = new AddDelegagte(P.AddSum);
            ad(200, 30);
            ad.Invoke(100, 30);
            SayDelegate sd = new SayDelegate(SayHello);
            string str = sd("Nilesh");
            string str1 = sd.Invoke("Sachin");
            Console.WriteLine(str+" "+str1);
            Console.ReadKey();

        }

    }

}
