using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_first_Entity.Models
{
    public class Employee
    {
        public int emp_Id { get; set; }
        public string emp_Name { get; set; }
        public string emp_Gender { get; set; }
        public string emp_Dept { get; set; }

    }
}