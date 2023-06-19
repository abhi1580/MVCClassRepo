using MVCUIDesigning.Models;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View();
        }
        //[HttpPost]
        //public ViewResult AddEmp(int? Id,string Name,string Job,double? Salary)
        //{
        //    ViewBag.Id=Id;
        //    ViewBag.Name=Name;
        //    ViewBag.Job=Job;
        //    ViewBag.Salary=Salary;
        //    return View("DisplayEmp1");
        //}

        //[HttpPost]
        //public ViewResult AddEmp(FormCollection fc) // No need to specify all the parameters instead use FormCollection
        //{
        //    ViewBag.Id = fc["Id"];
        //    ViewBag.Name = fc["Name"];
        //    ViewBag.Job = fc["Job"];
        //    ViewBag.Salary = fc["Salary"];

        //    return View("DisplayEmp1");

        //}
        [HttpPost]
        public ViewResult AddEmp(Employee model)
        {
            return View("DisplayEmp2", model);
        }
    }
}