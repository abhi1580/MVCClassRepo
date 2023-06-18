using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
     public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Validate()
        {
            string Name = Request["txtName"];
            string Password = Request["txtPwd"];

            if (Name == "Abhay" && Password == "Admin@123")
            {
                Session["User"] = Name;
                return View("Success");
            }
            else
                Session["User"]=Name;
            {
                return View("Failure");
            }
        }
    }
}