using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [TypeFilter(typeof(ActionFilter))]
        [HttpGet]
        [Route("hello")]
        public ActionResult Hello()
        {

            return Ok("hello");
        }



    }
}
