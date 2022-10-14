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
    public class CalculatorAdditionController : ControllerBase
    {
        [HttpGet]
        public double AddTwoNumbers([FromQuery] double number1, [FromQuery] double  number2)
            //this method of WebApi accept two numbers
            //in double data type
            //and use class library task addition already
            //made to return their sum
        {

            return CalculatorTasks.AdditionTask(number1, number2);
        }

       

     
    }
}
