using System;
using System.Threading;
using System.Web.Mvc;

namespace SnippetDemos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult CheckWhenMultipleAjaxCallsFinishDemo()
        {
            return View();
        }

        public ContentResult CheckWhenMultipleAjaxCallsFinishAction(int actionNo, int delayInSeconds)
        {
            Thread.Sleep(delayInSeconds * 1000);

            if (actionNo == 99)
            {
                throw new Exception($"Action {actionNo} failed");
            }

            return Content($"Action {actionNo} has completed");
        }
    }
}