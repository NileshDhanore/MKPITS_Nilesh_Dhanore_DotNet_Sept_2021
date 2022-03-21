using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Vehical
    {
        public int vehical_Number;  // instance variable
        public string model;
        public string company_Name;

        public abstract int Number_of_wheel();

        public void maretial_used_in_wheel()
        {
            Console.WriteLine("rubber");
        }
        public Vehical(int v, string m, string cn)
        {
            this.vehical_Number = v;
            this.model = m;
            this.company_Name = cn;

        }
        public override string ToString()
        {
            return "number = " + vehical_Number + "\n model :" + model + "\n name" + company_Name;
        }
    }
    class bus : Vehical
    {
        public string color;
        public string type;
        public override int Number_of_wheel()
        {
            return 4;
        }
        public bus(string c, string t,int v, string m, string cn): base(v,m,cn)
        {
            this.color = c;
            this.type = t;

        }
        public override string ToString()
        {
            return base.ToString()+"\n color : "+color+"\n type "+type;
        }

    }
}
