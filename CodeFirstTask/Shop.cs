namespace CodeFirstTask
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShopContext : DbContext
    {
        public ShopContext(string connString) 
            : base(connString)
        {
        } 
        public ShopContext()
            : base("MyConnection")
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