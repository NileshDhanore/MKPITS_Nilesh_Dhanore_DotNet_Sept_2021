using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_NOV26_CLASS_OBJECT_EMPLOYEE
{
    class Date
    {
        public int day, month, year;

        public Date()  //default constructor
        {
            day = 1;
            month = 1;
            year = 2000;
        }
        public Date(int d, int m, int y)  //parametarised constructor
        {
            day = d;
            month = m;
            year = y;
        }
        public void Display()
        {
            Console.WriteLine(day+"/"+month+"/"+year);
        }
    }
}
