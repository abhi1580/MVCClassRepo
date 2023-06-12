using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionResults.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Register()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        public ViewResult ForgetPassword()
        {
            return View("ForgetPwd");
        }

        public ViewResult ResetPassword()
        {
            return View("~/Views/Home/ResetPwd.cshtml"); // '~' used for pointing the current project folder
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult Mission()
        {
            return View("~/Views/Test/Mission.cshtml");
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Show(int id)
        {
            if (id == 1)
            {
                return View("Show1");
            }
            else
            {
                return View("Show2");
            }
        }
    }
}