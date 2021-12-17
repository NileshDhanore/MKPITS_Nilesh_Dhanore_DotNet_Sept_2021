using System;

namespace C_NOV26_Class_Object_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Date obj = new Date();
            obj.Display();
            Student obj1 = new Student(1, "Pooja", "Marbate", 23, 5, 6, 1998);
            obj1.ShowDetails();
        }
    }
}
