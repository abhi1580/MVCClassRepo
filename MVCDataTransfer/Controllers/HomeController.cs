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
            TempData["Id"] = Id;
            TempData["Name"] = Name;
            TempData["Price"] = Price;

            return RedirectToAction("Index4");
        }

        public ViewResult Index4()
        {
            return View();
        }

        public RedirectToRouteResult Index5(int? Id, string Name, double? Price)
        {
            TempData["Id"] = Id;
            TempData["Name"] = Name;
            TempData["Price"] = Price;

            return RedirectToAction("Index1","Test");
        }

        #endregion

        #region Cookie
        public ViewResult Index6(int? Id,string Name,double? Price)
        {
            HttpCookie cookie = new HttpCookie("ProductCookie");
            cookie["Id"] = Id.ToString();
            cookie["Name"] = Name;
            cookie["Price"] = Price.ToString();
            cookie.Expires=DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookie);
            return View();
        }
        public ViewResult Index7()
        {
            return View();
        }
        #endregion

        #region Session
        public RedirectToRouteResult Index8(int? id, string name, double? price)
        {
            Session["Id"] = id;
            Session["Name"] = name;
            Session["Price"] = price;
            return RedirectToAction("Index9");
        }
        public ViewResult Index9()
        {
            return View();
        }
        public RedirectToRouteResult Index10(int? id, string name, double? price)
        {
            Session["Id"] = id;
            Session["Name"] = name;
            Session["Price"] = price;
            return RedirectToAction("Index3", "Test");
        }


        #endregion

    }
}