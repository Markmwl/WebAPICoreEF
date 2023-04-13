using Dal;
using Dal.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebAPICore.Controllers
{
    [ApiController]
    [Route("Test")]
    public class TestController : Controller
    {
        [HttpGet, Route("GetUsers")]
        public List<用户表> Get()
        {
            Console.WriteLine("开始执行");
            Console.WriteLine(Dal.Common.Common.IsDevelopment);
            TestEF test = new();
            test.Test();
            Console.WriteLine("执行结束");
            return test.Test();
        }

        [HttpGet, Route("GetTest")]
        public string GetTest()
        {
            return "GetTest DEMO!";
        }
    }
}
