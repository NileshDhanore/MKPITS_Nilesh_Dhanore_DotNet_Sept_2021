using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Check_Call_FromBrowser.Controllers
{
    public class EmployeeController : Controller
    {
       public string EmployeeProfile(int id)
        {
            string profile = string.Empty;

            if(id == 1)
            {
                profile="Employee 1 Profile"; //To view in Browser us http://localhost:63086/Employee/EmployeeProfile?id=1
            }
            else if (id == 2)
            {
                profile= "Employee 2 Profile"; //To view in Browser us http://localhost:63086/Employee/EmployeeProfile?id=2
            }
            else
            {
                profile= "No record Found";
            }
            return profile;
        }
    }
}