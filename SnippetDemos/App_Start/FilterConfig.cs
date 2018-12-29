using SnippetDemos.Attributes;
using System.Web.Mvc;

namespace CodeCache
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new MyHandleErrorAttribute());
        }
    }
}