using Microsoft.AspNetCore.Mvc;

namespace CounterApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        
        public CounterController() {}

        [HttpGet]
        public ActionResult Increment()
        {
            return counter++;
        }



    }
}
