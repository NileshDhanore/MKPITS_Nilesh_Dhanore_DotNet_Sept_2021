using System;

namespace C_NOV26_Claass_Object_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(); //Employee is user defined data type
            obj.id = 1;
            obj.firstname = "Nilesh";
            obj.lastname = "Dhanore";
            obj.salary = 35000;
            obj.show();

            Employee obj1 = new Employee();
            obj1.id = 2;
            obj1.firstname = "Akash";
            obj1.lastname = "Narwade";
            obj1.salary = 25000;
            obj1.show();
            Employee obj3 = new Employee(3, "Hemant", "Dhanore", 200000);
            obj3.show();
            //Date birthday = new Date(); //constructor
            ////birthday.day = 8;
            ////birthday.month = 7;
            ////birthday.year = 1987;
            //Console.WriteLine("My Birthday is =" + birthday.day + "/" + birthday.month + "/" + birthday.year);
            //Date today = new Date(26,11,2021);
            //today.Display();
            //Date birthday = new Date(8,7,1987);
            //birthday.Display();


        }
        }

}
