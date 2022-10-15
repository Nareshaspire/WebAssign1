using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryCalculator;

namespace WebApiCalculator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorMultiplicationController : ControllerBase
    {
        [HttpGet]
        public double MultiplyTwoNumbers([FromQuery] double num1, [FromQuery] double num2)
       
        {

            return CalculatorApi.MultiplicationTask(num1, num2);
        }
    }
}
