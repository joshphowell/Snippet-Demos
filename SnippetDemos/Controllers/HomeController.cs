using System.Web.Mvc;

namespace SnippetDemos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}