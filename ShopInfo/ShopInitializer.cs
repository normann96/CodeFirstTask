using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ShopInfo
{
    class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            Product product1 = new Product() { Category = new Category() { Id = 1, Name = "Electronic equipment" }, Cost = 1000, Name = "Notebook" };
            Provider provider1 = new Provider() {Id = 888, Name = "Aliexpress", Product = product1, City = "Kiev" };

            Product product2 = new Product() { Category = new Category() { Id = 2, Name = "Fruit" }, Cost = 5, Name = "Apple" };
            Provider provider2 = new Provider() { Id = 777, Name = "Amazon", Product = product2, City = "Vegas" };

            Product product3 = new Product() { Category = new Category() { Id = 3, Name = "Accessory" }, Cost = 55, Name = "Umbrella" };
            Provider provider3 = new Provider() { Id = product3.Id, Name = "Aliexpress", Product = product3, City = "NY"};

            Product product4 = new Product() { Category = new Category() { Id = 4, Name = "Electronic equipment" }, Cost = 444, Name = "Kettle" }; ;
            Provider provider4 = new Provider() { Id = product4.Id, Name = "Amazon", Product = product4, City = "LA" };

            Product product5 = new Product() { Category = new Category() { Id = 5, Name = "Electronic equipment" }, Cost = 220, Name = "Mouse" };
            Provider provider5 = new Provider() { Id = product5.Id, Name = "Ebay", Product = product5, City = "LA" };

            Product product6 = new Product() { Category = new Category() { Id = 6, Name = "Food" }, Cost = 34, Name = "Fish" };
            Provider provider6 = new Provider() { Id = product6.Id, Name = "Ebay", Product = product6, City = "NY" };

            Product product7 = new Product() { Category = new Category() { Id = 7, Name = "Fruit" }, Cost = 6, Name = "Banana" };
            Provider provider7 = new Provider() { Id = product7.Id, Name = "Rozetka", Product = product7, City = "Kiev" };

            Product product8 = new Product() { Category = new Category() { Id = 8, Name = "Food" }, Cost = 15, Name = "Meat" };
            Provider provider8 = new Provider() { Id = product8.Id, Name = "Rozetka", Product = product8, City = "Vegas" };

            Product product9 = new Product() { Category = new Category() { Id = 9, Name = "Beverages" }, Cost = 2, Name = "Cola" };
            Provider provider9 = new Provider() { Id = product9.Id, Name = "Rozetka", Product = product9, City = "Jitomir" };

            Product product10 = new Product() { Category = new Category() { Id = 10, Name = "Beverages" }, Cost = 5, Name = "Coffee" };
            Provider provider10 = new Provider() { Id = product10.Id, Name = "Ebay", Product = product10, City = "Jitomir" };

            Product product11 = new Product() { Category = new Category() { Id = 11, Name = "Beverages" }, Cost = 3, Name = "Tea" };
            Provider provider11 = new Provider() { Id = product11.Id, Name = "Amazon", Product = product11, City = "Jitomir" };

            Product product12 = new Product() { Category = new Category() { Id = 12, Name = "Transport" }, Cost = 10000, Name = "Car" };
            Provider provider12 = new Provider() { Id = product12.Id, Name = "Aliexpress", Product = product12, City = "Vegas" };


            List<Product> products = new List<Product>()
            {
                product1, product2, product3, product4,
                product5, product6, product7, product8,
                product9, product10, product11, product12
            };

            List<Provider> providers = new List<Provider>()
            {
                provider1, provider2, provider3, provider4,
                provider5, provider6, provider7, provider8,
                provider9, provider10, provider11, provider12
            };

            context.Products.AddRange(products);
            context.Providers.AddRange(providers);

            context.SaveChanges();
        }
    }
}