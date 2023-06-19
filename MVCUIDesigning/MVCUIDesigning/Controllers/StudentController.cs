using MVCUIDesigning.Models;
using System.Web.Mvc;
namespace MVCUIDesigning.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ViewResult AddStudent()
        {

            return View();
        }

        [HttpPost]
        public ViewResult AddStudent(Student student)
        {

            return View("DisplayStudent", student);
        }
        [HttpGet]
        public ViewResult AddStudentST()
        {

            return View();
        }

        [HttpPost]
        public ViewResult AddStudentST(Student student)
        {

            return View("DisplayStudentST", student);
        }

        public PartialViewResult Header() //returns partial view as the result 
        {
            return PartialView("_Header");
        }


    }
}