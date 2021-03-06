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
        public int Add(int lValue, int rValue)
        {
            //Allow cross browser access of API
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Calculator.Add(lValue, rValue);
        }

        //Method for the Subtract endpoint
        [HttpGet]
        public int Subtract(int lValue, int rValue)
        {
            //Allow cross browser access of API
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Calculator.Subtract(lValue, rValue);
        }

        //Method for the Multiplication endpoint
        [HttpGet]
        public int Multiply(int lValue, int rValue)
        {
            //Allow cross browser access of API
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Calculator.Multiply(lValue, rValue);
        }

        //Method for the Divide endpoint
        [HttpGet]
        public double? Divide(int lValue, int rValue)
        {
            //Allow cross browser access of API
            Response.Headers.Add("Access-Control-Allow-Origin", "*");

            //Try-catch block for division, return status code 400 in case of exception (e.g. DivideByZeroException)
            try
            {
                return Calculator.Divide(lValue, rValue);
            }
            catch (Exception e)
            {
                Response.StatusCode = 400;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Bad Request";
                return null;
            }
        }
    }
}
