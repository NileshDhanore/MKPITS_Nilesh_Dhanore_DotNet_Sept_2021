using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_NOV26_Class_Object_Medicine
{
    class Medicine
    {
            public int fieldid;
            public string medicine_name, medicine_type;
            public decimal price;
            public Date expiry_date;
          
            public Medicine()
            {
                fieldid = 1;
                medicine_name = "Enter name of Medicine";
                medicine_type = "Enter type of Medicine";
                price = 10;
                expiry_date = new Date();
              
            }
            public Medicine(int fieldid, string medicine_name, string medicine_type, decimal price,int day, int month, int year)
            {
                this.fieldid = fieldid;
                this.medicine_name = medicine_name;
                this.medicine_type = medicine_type;
                this.price = price; 
                expiry_date = new Date(day, month, year);
                
            }
            public void show()
            {
                Console.WriteLine("Medicine id: " + fieldid + "\n Name of Medicine: " + medicine_name + "\n Type of Medicine: " + medicine_type + "\nprice: " + price);
                Console.WriteLine("Date of Expiry of Medicine");
                expiry_date.Display();
            }
        }
}
