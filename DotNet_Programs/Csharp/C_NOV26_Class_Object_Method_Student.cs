using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV26_Class_Object_Method
{
    class Student
    {
        public int Studentid;
        public string Firstname, Lastname;
        public int marks;
        public Date dob;
        public Student() //default Constructor
        {
            Studentid = 1;
            Firstname = "Nameof Student";
            Lastname = "Lastname of Student";
            marks = 50;
            dob = new Date();   // default date in contructor
        }
    
    public Student(int Studentid,string Firstname, string Lastname, int marks,int day,int month,int year)
        {
            this.Studentid = Studentid;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.marks = marks;
            dob = new Date(day,month,year);
         }
        public void ShowDetails()
        {
            Console.WriteLine("Student ID : " +Studentid+" "+Firstname+" "+Lastname+" "+marks);
            Console.WriteLine("Date of Birth");
            dob.Display();

        }
        
    

    }
}
