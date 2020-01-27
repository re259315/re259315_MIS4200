using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace re259315_MIS4200.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public DateTime customerSince { get; set; }
    }
}