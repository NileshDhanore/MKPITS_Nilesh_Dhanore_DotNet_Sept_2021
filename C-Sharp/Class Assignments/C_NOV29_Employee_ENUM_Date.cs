using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV29_Employee_ENUM
{
    class Date
    {
        int day, month, year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public Date()
        {
            day = 01;
            month = 01;
            year = 2000;
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return "Date: " + day + "/" + month + "/" + year;
        }

    }
}
    
    
    
    
    
    
    


