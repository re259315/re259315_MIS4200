using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace re259315_MIS4200.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }


    }
}