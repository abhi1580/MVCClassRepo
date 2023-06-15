using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class DemoController : Controller
    {
        public string Index()
        {
            return "Message from Demo Controller and Index Method";
        }

        public string Show()
        {
            return "Message from Demo Controller and Show Method";
        }
    }
}