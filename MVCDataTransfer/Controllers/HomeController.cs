using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        #region ViewData
        public ViewResult Index1(int? Id,string Name,double? Price)
        {
            ViewData["id"] = Id;
            ViewData["name"] = Name;
            ViewData["Price"] = Price;
            return View();
        }
        public ViewResult Display1()
        {
            string[] Colors = { "Red", "Blue", "Pink", "Black", "Cyan", "Green", "Brown", "Purple" };
            ViewData["Colors"] = Colors;
            return View();
        }
        #endregion

        #region ViewBag

        public ActionResult Index2(int? Id,string Name,double? Price) {

            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Price = Price;

            return View();
        
        }

        public ViewResult Display2()
        {
            string[] Colors = { "Red", "Blue", "Pink", "Black", "Cyan", "Green", "Brown", "Purple" };
            ViewBag.Colors = Colors;
            return View();
        }

        #endregion

        #region TempData

        public RedirectToRouteResult Index3(int? Id, string Name, double? Price)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            TempData["Price"] = Price;

            return RedirectToAction("Index4");
        }

        public ViewResult Index4()
        {
            return View();
        }

        #endregion

    }
}