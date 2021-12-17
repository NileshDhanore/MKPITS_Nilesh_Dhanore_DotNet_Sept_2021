using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV29_Static_Field_Static_Function
{
    class Student
    {
        //auto implimented properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public static int Count { get; set; }
        public Student()
        {
            Id = 1;
            Name = "Bill";
            Marks = 78;
            Count++; //shared field by all objects
        }
        public Student(int id,string name,int marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
            Count++; 
        }
        //object method: it is called with object  s1.show

        public void ShowResult()
        {
            if(Marks>=50)
                Console.WriteLine(Name+" is Pass");
            else
                Console.WriteLine(Name+" is Fail");
        }
        //static method it is called with class ex: student.ShowCount()
        public static void ShowCount()
        {
            Console.WriteLine("Total Number of students objects " +Count);
        }
    }
}
