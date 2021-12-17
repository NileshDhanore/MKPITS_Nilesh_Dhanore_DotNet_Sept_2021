using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_NOV29_Static_object_Employee
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public static int Count { get; set; }

        public Employee()
        {
            Id = 1;
            Name = "Nilesh";
            Salary = 1000;
            Count++;
        }
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Count++;
        }
        public static void ShowCount()
        {
            Console.WriteLine("Total Number of Employees Data is :  " +Count);
        }
        public decimal GrossSalary()
        {
            decimal Gross = Salary + Salary * 0.75m + Salary * 0.1m + 1500;
            return Gross;
        }
        public decimal NetSalary()
        {
            decimal Net = GrossSalary() - 768.7m;
            return Net;
        }
}
}
