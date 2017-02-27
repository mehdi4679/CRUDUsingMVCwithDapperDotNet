using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDUsingMVCwithAdoDotNet.Controllers
{
    public class Person2Controller : ApiController
    {
        // GET: api/Person2
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Person2/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person2/5
        public void Delete(int id)
        {
        }
    }
}
