using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebApp
{
    [Serializable]
    public class Person
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
    }
}