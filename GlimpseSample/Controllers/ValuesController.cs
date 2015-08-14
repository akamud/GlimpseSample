using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlimpseSample.Controllers
{
    [Route("api/values")]
    public class ValuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("value1");
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
