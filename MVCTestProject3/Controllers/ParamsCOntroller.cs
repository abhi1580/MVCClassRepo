using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject3.Controllers
{
    public class ParamsCOntroller : Controller
    {
        [ActionName("SayHello1")]
        public string SayHello()
        {
            return "Hello How Are you?";
        }
         
        [ActionName("SayHello2")]
        public string SayHello(string name) //to call this method in url ---> /Params/SayHello2?name=Abhay
        {
            return "Hello"+name+ "How Are you?";
        }

        [NonAction]
        public string Display()
        {
            return "Action method with no action attribute"; //It cant be executed on browser
        }
    }
}