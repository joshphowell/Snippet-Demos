using System;
using System.Configuration;
using System.Web.Mvc;

namespace SnippetDemos.Attributes
{
    public class MyHandleErrorAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.HttpContext.IsDebuggingEnabled)
            {
                return;
            }

            if (!filterContext.ExceptionHandled || Convert.ToBoolean(ConfigurationManager.AppSettings["logHandledExceptions"]))
            {
                // TODO: Log exception
            }

            if (!filterContext.ExceptionHandled)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "~/Views/Shared/Error.cshtml"
                };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}