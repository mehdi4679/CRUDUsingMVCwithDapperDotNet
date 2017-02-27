using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUDUsingMVCwithAdoDotNet.Models;
 using System.Data;
 using System.Web.Http.Description;
 

namespace CRUDUsingMVCwithAdoDotNet.Controllers
{
    public class PersonApiController : ApiController
    {
        // GET: api/PersonApi
         
        public List<Person> GetList()
        {
            Person obj = new Person();
            Repository.PersonRepository cl = new Repository.PersonRepository();
          List<Person>p=  cl.Getlist(obj);
            return p;
         }
         public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }


        // GET: api/PersonApi/5
        public string Get(int id)
        {
            return "6665";
        }

        // POST: api/PersonApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PersonApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PersonApi/5
        public void Delete(int id)
        {
        }
    }
}
