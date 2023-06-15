using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "Message from Home Controller and Index Method";
        }

        public string Show()
        {
            return "Message from Home Controller and Show Method";
        }
    }
}