using DataAbstractionLayer;
using MathWorks.MATLAB.NET.Arrays;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/sumresult")]
    [ApiController]
    public class SummingController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult GetAnswer(int a, int b)
        {
            DataAbstractionLayer.Class1 class1 = new DataAbstractionLayer.Class1();
            return Ok(class1.sum_result(a, b));
        }
    }
}
