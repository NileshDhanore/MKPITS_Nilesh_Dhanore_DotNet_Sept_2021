using System;

namespace C_Nov30_Convert_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            char rainbowcolor;
            Console.WriteLine("Enter color code");
            rainbowcolor = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Rainbow Color is " +rainbowcolor);
            decimal price;
            Console.WriteLine("Enter Price");
            price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Price = {0:C}",price);
            bool ans = true;
            Console.WriteLine("Enter answere true/false");
            ans = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("yes i want to repeat " +ans);
            DateTime today;
            Console.WriteLine("Enter Date");
            today = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("today is " + today);

        }
    }
}
