using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Check_Call_FromBrowser.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index() 
        {
            return "Hello Everyone u can see the data by default";//Browser will show this data as default http://localhost:63086/ because in Route configuration default action method is Index  
        }                                                        // We can show it like http://localhost:63086/Home/Index

        public string Name()
        {
            return " My name is Nilesh Dhanore"; // We can view it by wrtting http://localhost:63086/Home/Name  in browser.
        }
    }
}