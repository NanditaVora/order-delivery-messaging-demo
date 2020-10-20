using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase    
    {
        // GET: api/<DeliveryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "delivery1", "delivery2" };
        }

        // GET api/<DeliveryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DeliveryController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            return Created("api/delivery", "order delivered");
        }

        // PUT api/<DeliveryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DeliveryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
