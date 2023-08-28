using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend_app.Models
{

    public class Employee
    {
        public int id { get; set; }
        public int Name { get; set; }
        public int PhoneNo { get; set; }
        public int Address { get; set; }
        public int IsActive { get; set; }
    }
}