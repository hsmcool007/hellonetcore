using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IService;
using WebApplication1.Service;

namespace WebApplication1.Filters
{
    public class ActionFilter : IActionFilter
    {

        private ITestService _ITestService;


        public ActionFilter(ITestService testService)
        {
            _ITestService = testService;
        }



        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Response.WriteAsync($"{_ITestService.hello()} in. \r\n");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.WriteAsync($"{GetType().Name} out. \r\n");
        }
    }
}
