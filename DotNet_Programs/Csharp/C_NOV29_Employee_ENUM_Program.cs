using System;

namespace C_NOV29_Employee_ENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            //d1.Day = 29; //if set is not written the property is ReadOnlyMemory only
                         //and this statement is not allowed
            Console.WriteLine(d1.Day);
            Employee obj = new Employee(1, "Nilesh Dhanore", 2000,Department.IT,23,5,2006);
        }
    }
}