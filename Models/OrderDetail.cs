using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace re259315_MIS4200.Models
{
    public class OrderDetail
    {
        public int orderdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        public int orderID { get; set; }
        public virtual Order Order { get; set; }
        public int productID { get; set; }

        public virtual Product Product { get; set; }
}

}
