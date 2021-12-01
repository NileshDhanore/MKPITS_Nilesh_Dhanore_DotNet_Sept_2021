using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV29_Employee_ENUM
{
    enum Department { HR,IT,Account,CIVIL,PRODUCTION,ELECTRICAL};
    class Employee
    {
        int id;
        string name;
        Department department;
        decimal salary;
        Date doj;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Salary { get => salary; set => salary = value; }
        internal Department Department { get => department; set => department = value; }
        public Employee()
        {
            id = 1;
            name = "Nilesh dhanore";
            department = Department.HR;
            doj = new Date();

        }
        public Employee(int id, string name,decimal salary,Department department,Date doj)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.department = department;
            this.doj = doj;
                
        }
        public override string ToString()
        {
            return "Employee id : " + id + "\nEmployee Name :" + name + "Employee salary: " + salary + "Employee Department: " + department + "Date of Joining" + doj;
        }

    }
}
