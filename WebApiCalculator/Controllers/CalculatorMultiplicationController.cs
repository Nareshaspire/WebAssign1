﻿using Microsoft.AspNetCore.Http;
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
        //this method of WebApi accept two numbers
        //in double data type
        //and use class library task multiplication already
        //made to return the result of product of two numbers
        {

            return CalculatorApi.MultiplicationTask(num1, num2);
        }
    }
}
