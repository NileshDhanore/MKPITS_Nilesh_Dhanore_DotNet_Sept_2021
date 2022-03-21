using System;

namespace Input_form_user
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter your first Number");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your last Name");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Addition is "+sum);
            Console.ReadLine();  //concatination of two string
        }
    }
}
