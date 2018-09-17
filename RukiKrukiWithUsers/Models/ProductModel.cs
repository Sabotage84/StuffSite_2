namespace RukiKrukiWithUsers.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductModel : DbContext
    {
        
        public ProductModel()
            : base("name=ProductModel")
        {
        }

        
       public virtual DbSet<Product> Products { get; set; }
    }

    
}