using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace WebAPI2.Learning.Filters
{
    public class CustomExceptionFilter :IExceptionFilter
    {
        public bool AllowMultiple => false;

        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            Debug.WriteLine(actionExecutedContext.Exception.Message);

            throw actionExecutedContext.Exception;
        }
    }
}