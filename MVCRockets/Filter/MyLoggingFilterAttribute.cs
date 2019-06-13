using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockets.Filter
{
    //Create  filter
    public class MyLoggingFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var request = filterContext.HttpContext.Request;

            //TODO: Add my custom logic
                base.OnActionExecuted(filterContext);
        }
    }
}