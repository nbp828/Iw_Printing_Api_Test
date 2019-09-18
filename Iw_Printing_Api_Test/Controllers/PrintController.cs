using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IwPrintingCalculator;
using Microsoft.AspNetCore.Mvc;

namespace Iw_Printing_Api_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Welcome to InnerWorkings Printing";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] List<string> value)
        {
            try
            {
                PrintJobParser parser = new PrintJobParser();
                PrintJob job = parser.Parse(value);
                PrintCostCalculator calculator = new PrintCostCalculator();
                return calculator.Calculate(job);
            }
            catch (PrintJobException)
            {
                return "Parsing error! Please provide valid input";
            }
            catch (Exception)
            {
                return "An unknown error has occurred";
            }
            
        }
    }
}
