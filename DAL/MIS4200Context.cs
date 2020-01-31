using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using re259315_MIS4200.Models;
using System.Data.Entity;

namespace re259315_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}