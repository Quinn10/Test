using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine
{
    public class MyErrorHandlerAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (ExceptionType == typeof(Exception))
                View = "Error";
            if (ExceptionType == typeof(DivideByZeroException))
                View = "ErrorSQL";

            base.OnException(filterContext);
        }
    }
}