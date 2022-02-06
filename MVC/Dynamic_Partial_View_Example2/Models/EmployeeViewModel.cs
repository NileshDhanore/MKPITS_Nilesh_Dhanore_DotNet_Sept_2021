using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dynamic_Partial_View_Example2.Models
{
    public class EmployeeViewModel
    {
       
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            [Display(Name = "Confirm Password")]
            public string ConfirmPassword { get; set; }
        }

    }
