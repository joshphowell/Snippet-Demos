using SnippetDemos.Helpers;
using System;
using System.Threading;
using System.Web.Mvc;

namespace SnippetDemos.Controllers
{
    public class DemoController : Controller
    {
        private readonly DemoHelper _DemoHelper = new DemoHelper();

        public ViewResult CheckWhenMultipleAjaxCallsFinishDemo()
        {
            return View();
        }

        public ContentResult CheckWhenMultipleAjaxCallsFinish(int actionNo, int delayInSeconds)
        {
            Thread.Sleep(delayInSeconds * 1000);

            if (actionNo == 99)
            {
                throw new Exception($"Action {actionNo} failed");
            }

            return Content($"Action {actionNo} has completed");
        }

        public ViewResult JQueryDataTableDemo()
        {
            return View();
        }

        public JsonResult JQueryDataTablePartial(int rowCount = 10)
        {
            var result = Json(new { data = _DemoHelper.GetTestData(rowCount) }, JsonRequestBehavior.AllowGet);

            return result;
        }
    }
}