using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IService;

namespace WebApplication1.Service
{
    public class TestService : ITestService
    {
        public string hello()
        {
            return "nihao";
        }
    }
}
