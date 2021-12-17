using System;

namespace H_NOV29_Static_object_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Akash", 32000);
            Console.WriteLine("The Gross salary : {0:C}",e1.GrossSalary());
            Console.WriteLine("The Net salary : {0:C}", e1.NetSalary());
            Employee.ShowCount();
            Employee e2, e3, e4;
            e2 = new Employee(2, "Hritvik", 30000);
            e3 = new Employee(3, "Roshan", 40077);
            e4 = new Employee(4, "Pooja", 67000);
            Employee.ShowCount();
        }
    }
}
