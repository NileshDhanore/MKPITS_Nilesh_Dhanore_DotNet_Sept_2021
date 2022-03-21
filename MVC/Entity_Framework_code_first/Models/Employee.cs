using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity_Framework_code_first.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}