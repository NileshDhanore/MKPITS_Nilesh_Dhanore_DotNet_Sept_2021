using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV26_Class_Object_Method
{
    class Date
    {
        public int date, month, year;

        public Date()

        {
            date = 1;
            month = 1;
            year = 2000;
        }
        public Date(int d, int m, int y)
        {
            date = d;
            month = m;
            year = y;
        }
        public void Display()
        {
            Console.WriteLine(date+"/"+month+"/"+year);
        }
    }
}


