using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDUsingMVCwithAdoDotNet.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string FatherName { get; set; }

    }
    public class PersonList
    {
        List<Person> Rows { get; set; }
    }
}