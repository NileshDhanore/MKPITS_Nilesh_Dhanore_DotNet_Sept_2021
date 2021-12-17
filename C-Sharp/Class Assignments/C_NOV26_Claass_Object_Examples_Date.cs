using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV26_Claass_Object_Examples
{
    class Date //user defined data type
    {
        public int day, month, year;  //together ness of three values

        public Date()  //default contructor
        {
            day = 15;
            month = 8;
            year = 1947;
        }
        public Date(int d, int m, int y)  //parametaried contructor
        {
            day = d;               // values of d,m,y  are comming from outside word
            month = m;         // from main function
            year = y;
        }
        public void Display()
        {
        Console.WriteLine(day+"/"+month+"/"+year);
        }

    }
}
