using System; //header file

namespace C_NOV21_myconsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //code1
            // Console.WriteLine("Hello World!");//cursore goes to next line
            //  Console.Write("Hello I am Nilesh Dhanore. Assistant Professor at JIT\n");// like c we use \n
            // Console.Write("Hello I also .net developer");
            //  Console.Write("Hello I also HTML developer");  //

            //code2

            int x = 10, y = 5;
            double pi = 3.14243;
                            char color = 'r';
            decimal price = 45.50m; // m for money
            string name = "Nilesh";
            //Console.WriteLine("x= " + x + "y= " + y);

            //write cw and press tab key
            //control kc for comment to cncel control use control ku

            //Console.WriteLine("pi= " +pi+ "price= "  +price);
            //Console.WriteLine("My name is " + name);
            //Console.WriteLine("color code = " +color);

            ////formated output of numerical data

            //Console.WriteLine("x={0}  y={1}  pi={2:F2}  price= {3:c}", x, y, pi, price);

            //code 3 : Input Statement

            //Console.WriteLine("Enter your Name");
            //name = Console.ReadLine();
            //Console.WriteLine("My name is " +name);
            //Console.WriteLine("Enter the value of x");

            //x = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Enter the value of y");

            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("x+y= "+(x+y));

            //code 4 Area of Circle

            //Console.WriteLine("Enter the value of radius");
            //x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Formated ouput of Area of Circle is={0:F2}" , (pi * x * x));
            //double Area = Math.PI * x * x;
            //Console.WriteLine("String format Area of Circle is = " +Area);

            //code 5 Display 1 to 10
            Console.WriteLine("Display 1 to 10 Numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            
            }


            Console.ReadKey();
        }
    }
}
