using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ShopInfo
{
    public class ShopContext : DbContext
    {
        public ShopContext(string connString = "ShopDB")
            : base(connString)
        {
        }

        static ShopContext()
        {
            Database.SetInitializer(new ShopInitializer());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }

    }

}