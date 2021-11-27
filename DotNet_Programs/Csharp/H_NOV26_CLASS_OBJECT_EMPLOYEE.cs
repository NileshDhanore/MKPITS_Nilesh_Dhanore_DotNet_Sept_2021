using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_NOV26_CLASS_OBJECT_EMPLOYEE
{
    class Employee
    {
        public int fieldid;
        public string name, des;
        public Date doj;
        public decimal salary;

        public Employee()
        {
            fieldid = 1;
            name = "Enter your name";
            des = "Field the designation";
            doj = new Date();
            salary = 1000;
        }
        public Employee(int fieldid, string name, string des, int day, int month, int year, decimal salary)
        {
            this.fieldid = fieldid;
            this.name = name;
            this.des = des;
            doj = new Date(day, month, year);
            this.salary = salary;
        }
        public void show()
        {
            Console.WriteLine("Employee id: " +fieldid+"\n Name of Employee: "+name+"\n Designation: "+des+"\nSalary "+salary);
            Console.WriteLine("Date of Joining");
            doj.Display();
        }
                      
    }
}
