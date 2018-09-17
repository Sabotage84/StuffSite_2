using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RukiKrukiWithUsers.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("ProductsDB")
        { }

        public virtual DbSet<Product> Products { get; set; }
    }
}