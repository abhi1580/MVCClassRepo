using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestPject3.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string name = "ABhay";

            int len = name.Length;
            return "Hello from Home Controller - Index Method and length of the string variable is = "+len;
        }

        public string Show()
        {
            return "Hello from Home Controller - Show Method";
        }
    }
}