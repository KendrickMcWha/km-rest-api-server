using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace km_rest_api_server.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class RandomNumberController : ControllerBase
    {
        // GET: api/<RandomNumberController>
        [HttpGet]
        public string Get()
        {
            //return new string[] { "value1", "value2" };
            Random rand = new Random();
            int randNum = rand.Next( 100 );
            return randNum.ToString();
        }

        // GET api/<RandomNumberController>/5
        [HttpGet( "{id}" )]
        public string Get( int id )
        {
            return "value";
        }

        // POST api/<RandomNumberController>
        [HttpPost]
        public void Post( [FromBody] string value )
        {
        }

        // PUT api/<RandomNumberController>/5
        [HttpPut( "{id}" )]
        public void Put( int id, [FromBody] string value )
        {
        }

        // DELETE api/<RandomNumberController>/5
        [HttpDelete( "{id}" )]
        public void Delete( int id )
        {
        }
    }
}
