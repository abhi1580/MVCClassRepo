using ActionResultsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ActionResultsInMVC.Controllers
{
    public class ResultsController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public JsonResult GetEmployees()
        {
            Employee e1 = new Employee { Id = 101, Name = "Scott", Job = "CEO", Salary = 25000, Status = true };
            Employee e2 = new Employee { Id = 102, Name = "Smith", Job = "President", Salary = 22000, Status = true };
            Employee e3 = new Employee { Id = 103, Name = "Parker", Job = "Manager", Salary = 18000, Status = true };
            Employee e4 = new Employee { Id = 104, Name = "John", Job = "Salesman", Salary = 10000, Status = true };
            Employee e5 = new Employee { Id = 105, Name = "David", Job = "Clerk", Salary = 5000, Status = true };
            Employee e6 = new Employee { Id = 106, Name = "Maria", Job = "Analyst", Salary = 12000, Status = true };
            List<Employee> Emps = new List<Employee> { e1, e2, e3, e4, e5, e6 };
            return Json(Emps, JsonRequestBehavior.AllowGet);
        }

        public FileResult DownloadPdf()
        {
            return File("~/Downloads/1.Fee Receipt.pdf", "application/pdf");
        }
        public FileResult DownloadWord()
        {
            return File("~/Downloads/MVC Complete Notes.doc", "application/msword");
        }

        public RedirectResult OpenFacebook()
        {
            return Redirect("http://facebook.com");
        }

        public RedirectResult OpenTwitter()
        {
            return Redirect("http://twitter.com");
        }

        public ContentResult SendDate1()
        {
            return Content("Current Date: " + DateTime.Now.ToString());
        }

        public string SendDate2()
        {
            return "Current Date: " + DateTime.Now.ToString();
        }

        public string SayHello1()
        {
            return "नमस्ते आप कैसे हैं ? ";
        }

        public ContentResult SayHello2()
        {
            return Content("नमस्ते आप कैसे हैं ? ", "text/plain", System.Text.Encoding.Unicode);
        }

        public JavaScriptResult AlertUser() //Wont work because browsers are not supporting now
        {
            return JavaScript("alert('Hello how are you ?')");
        }

        public EmptyResult ReturnEmpty1()//Wont return anything
        {
            EmptyResult obj = new EmptyResult();

            return obj;
        }

        public void ReturnEmpty2()//Wont return anything
        {
            string str = "How are you?";
            str = str.ToUpper();
        }

    }
}