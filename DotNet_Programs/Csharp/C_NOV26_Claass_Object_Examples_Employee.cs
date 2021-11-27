using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV26_Claass_Object_Examples
{
    class Employee
    {
      public  int id;
     public   string firstname, lastname;
        public decimal salary;

        public Employee()
        {
            id = 2;
            firstname = "Nilesh";
            lastname = "Dhanore";
            salary = 50000;
        }

        public Employee(int id,string fname,string lname,decimal salary)
        {
            this.id = id;
            firstname = fname;
            lastname = lname;
            this.salary = salary;
        }
        public void show()
        {
            Console.WriteLine(id+ " "+firstname +"  " + lastname + "  " +salary);
        }
    }
}
