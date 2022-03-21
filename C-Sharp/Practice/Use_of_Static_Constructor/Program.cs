using System;

namespace Use_of_Static_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(23,24,"Nilesh");
            Student s2 = new Student(22, 54, "Akash");

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2);


        }
    }
   public class Student
    {
        public int id;
        public string name;
        public int age;
        //public static string College_name="JIT";
        public static string College_name;

        public Student(int id, int age, string name)
        {
            this.id = id;   // this indicates current object
            this.name = name;
            this.age = age;

        }
        static Student()
        {
            College_name = "JIT";

            
        }
        public override string ToString()
        {
            return "id = " + id + " \n name = " + name + " \nage = " + age+ "college name = "+College_name;
        }
    }
}
