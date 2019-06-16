using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOps.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevOps.Controllers
{
   // [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class DevOpsController : ControllerBase
    {
        // GET: api/DevOps
        [HttpGet]
        [HttpPut]
        [HttpDelete]
          public ActionResult Get()
        {
            var run = " ERROR ";
            return new OkObjectResult(run);
          
        }

        // GET: api/DevOps/5
        [HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        public ActionResult Get(string id)
        {
            var run = " ERROR ";
            return new OkObjectResult(run);
        }

        // POST: api/DevOps
        [HttpPost]
        public IActionResult Post([FromBody] Entrust entrust)
        {
            MsgResponse msgResponse = new MsgResponse();

            if (entrust != null)
            {
                if (entrust.message != "" && entrust.to != "" && entrust.from != "" && entrust.timeToLifeSec > 0)
                {
                    msgResponse.message = "Hello " + entrust.to + " your message will be send";
                    return new OkObjectResult(msgResponse);
                }
                else
                {
                    msgResponse.message = "Datos Incompletos, Request ERROR ";
                    return new OkObjectResult(msgResponse);
                }

            }
            else
            {
                var run = " ERROR ";
                return new OkObjectResult(run);
            }
                
        }

    }
}
