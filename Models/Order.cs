using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace re259315_MIS4200.Models
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }

        public ICollection<OrderDetail> OrderDetail { get; set; }

        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}