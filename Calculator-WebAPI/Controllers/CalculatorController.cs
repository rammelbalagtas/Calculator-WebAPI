using Calculator_ClassLibrary;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")] 
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        //Method for the Add endpoint
        [HttpGet]
        public int? Add(int lValue, int rValue)
        {
            //Allow cross browser access of API
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Calculator.Add(lValue, rValue);
        }

        //Method for the Subtract endpoint
        [HttpGet]
        public int? Subtract(int lValue, int rValue)
        {
            //Allow cross browser access of API
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Calculator.Subtract(lValue, rValue);
        }
    }
}
