using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        [HttpPost("Add/{num1}/{num2}")]
        public ActionResult<int> Add(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpPost("Subtract/{num1}/{num2}")]
        public ActionResult<int> Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        [HttpPost("Multiply/{num1}/{num2}")]
        public ActionResult<int> Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        [HttpPost("Divide/{num1}/{num2}")]
        public ActionResult<decimal> Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
