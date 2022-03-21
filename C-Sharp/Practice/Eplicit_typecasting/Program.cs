using System;

namespace Eplicit_typecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "12345";
            int b =Convert.ToInt32( a);
            int c = int.Parse(a);
            Console.WriteLine(c);
        }
    }
}
