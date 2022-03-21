using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            bus B1 = new bus("pink","school bus",12,"Star","Tata");
            Console.WriteLine(B1);

            B1.maretial_used_in_wheel();
            Console.WriteLine(B1.Number_of_wheel()) ;

            Vehical B2=new bus("red", "school bus", 12, "Star", "Tata");
        }
    }
}

