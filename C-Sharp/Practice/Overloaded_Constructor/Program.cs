using System;

namespace Overloaded_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(2,"nilesh","marathi",34);
            //Employee e2 = new Employee();
            //Employee e3 = new Employee();
            //Employee e4 = new Employee();
            Console.WriteLine(e1);
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string department { get; set; }
        public int Age { get; set; }
        public static string compnyname { get; set; }
        //public Employee()
        //{
        //    Id = 1;
        //    Name = "Nilesh";
        //    department = "IT";
        //    Age = 33;
        //}
        public Employee(int i, string n, string d, int age)
        {
            this.Id = i;
            this.Name = n;
            this.department = d;
            this.Age = age;
            Console.WriteLine("instance constructor");

        }
        //public Employee(int i, string n)
        //{
        //    this.Id = i;
        //    this.Name = n;

        //}
        //public Employee( string d, int age)
        //{

        //    this.department = d;
        //    this.Age = age;
        //}

        static Employee()
        {
            compnyname = "jit";
            Console.WriteLine("static constructor");
        }
    }
}
