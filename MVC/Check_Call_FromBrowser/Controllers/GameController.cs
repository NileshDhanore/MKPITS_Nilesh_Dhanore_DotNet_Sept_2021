using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Check_Call_FromBrowser.Controllers
{
    public class GameController : Controller
    {
        string profile = string.Empty;
        
        public string Name(string name)
        {
            if (name=="Webgentle")  // local:XXX/Game/Name?name=Wbgentle
             profile= "Welcome to Webgentle";
            return profile;
        }
        public string Fullname(string first, string last)
        {
            if(first=="firstname" && last == "lastname") // local:XXX/Game/fullname?first=firstname&last=lastname;
            {
                 
                profile = "your firstname is = " + first+ " and your lastname is = " + last; ;
                
            }
            else if (first=="firstname")// local:XXX/Game/fullname?first=firstname;
            {
                profile = "your firstname is = " + first;
            }
            else if (last == "lastname")// local:XXX/Game/fullname?first=firstname;
            {
                profile = "your lastname is = " + last;
            }
            return profile;
        }
    }
}