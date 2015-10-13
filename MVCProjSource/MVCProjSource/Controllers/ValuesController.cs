using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCProjSource.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        // First Change by JB 1
        // Second Change by JB 2
        // First Change by RB 1

        public IEnumerable<string> Get()
        {
            return new string[] { "valueJB7", "valueJB8" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value8";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}