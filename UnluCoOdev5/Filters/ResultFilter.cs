using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCoWeek5.Filters
{
    public class ResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var headerName = "OnResultExecuting";
            context.HttpContext.Response.Headers.Add(
               headerName,new string[] { "It's Success" });
            var Time = "CreationTime";
            context.HttpContext.Response.Headers.Add(Time, new string[] { DateTime.Now.ToString(),}) ;
        }
    }
}
