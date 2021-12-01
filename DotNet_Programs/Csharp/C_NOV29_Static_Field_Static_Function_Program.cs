using System;

namespace C_NOV29_Static_Field_Static_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            //Console.WriteLine("count = " +Student.Count);
            Student s2 = new Student(2,"Nilesh",45);
            Student s3 = new Student(2, "Pakhi", 34);
            Student s4 = new Student(2, "Poorvansh", 68);
            Student s5 = new Student(2, "Kishor", 12);
            //Student.ShowCount();
            //s1.ShowResult();
            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = s4;
            students[4] = s5;
            Console.WriteLine("The result of Students is as follows");
                for (int i=0;i<5;i++)
            {
                students[i].ShowResult();
            }

        }
    }
}
