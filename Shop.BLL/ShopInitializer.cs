using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Shop.BLL
{
    class ShopInitializer : DropCreateDatabaseAlways< ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            Category category1 = new Category() { Id = 1, Name = "testCategory" };
            Product product1 = new Product() { Id = 1, Cost = 100, Name = "TestName", Category = category1 };
            Provider provider1 = new Provider() { Id = product1.Id, Name = "Aliexpress", Product = product1, City = "Kiev" };

            Category category2 = new Category() { Id = 2, Name = "Fruit" };
            Product product2 = new Product() { Category = category2, Cost = 5, Name = "Apple", Id = category2.Id };
            Provider provider2 = new Provider() { Id = 777, Name = "Amazon", Product = product2, City = "Vegas" };

            Category category3 = new Category() { Id = 3, Name = "Accessory" };
            Product product3 = new Product() { Category = category3, Cost = 55, Name = "Umbrella", Id = category3.Id };
            Provider provider3 = new Provider() { Id = product3.Id, Name = "Aliexpress", Product = product3, City = "NY" };

            Category category4 = new Category() { Id = 4, Name = "Electronic equipment" };
            Product product4 = new Product() { Category = category4, Cost = 444, Name = "Kettle", Id = category4.Id }; ;
            Provider provider4 = new Provider() { Id = product4.Id, Name = "Amazon", Product = product4, City = "LA" };

            Category category5 = new Category() { Id = 5, Name = "Electronic equipment" };
            Product product5 = new Product() { Category = category5, Cost = 220, Name = "Mouse", Id = category5.Id };
            Provider provider5 = new Provider() { Id = product5.Id, Name = "Ebay", Product = product5, City = "LA" };

            Category category6 = new Category() { Id = 6, Name = "Food" };
            Product product6 = new Product() { Category = category6, Cost = 34, Name = "Fish", Id = category6.Id };
            Provider provider6 = new Provider() { Id = product6.Id, Name = "Ebay", Product = product6, City = "NY" };

            Category category7 = new Category() { Id = 7, Name = "Fruit" };
            Product product7 = new Product() { Category = category7, Cost = 6, Name = "Banana", Id = category7.Id };
            Provider provider7 = new Provider() { Id = product7.Id, Name = "Rozetka", Product = product7, City = "Kiev" };

            Category category8 = new Category() { Id = 8, Name = "Food" };
            Product product8 = new Product() { Category = category8, Cost = 15, Name = "Meat", Id = category8.Id };
            Provider provider8 = new Provider() { Id = product8.Id, Name = "Rozetka", Product = product8, City = "Vegas" };

            Category category9 = new Category() { Id = 9, Name = "Beverages" };
            Product product9 = new Product() { Category = category9, Cost = 2, Name = "Cola", Id = category9.Id };
            Provider provider9 = new Provider() { Id = product9.Id, Name = "Rozetka", Product = product9, City = "Jitomir" };

            Category category10 = new Category() { Id = 10, Name = "Beverages" };
            Product product10 = new Product() { Category = category10, Cost = 5, Name = "Coffee", Id = category10.Id };
            Provider provider10 = new Provider() { Id = product10.Id, Name = "Ebay", Product = product10, City = "Jitomir" };

            Category category11 = new Category() { Id = 11, Name = "Beverages" };
            Product product11 = new Product() { Category = category11, Cost = 3, Name = "Tea", Id = category11.Id };
            Provider provider11 = new Provider() { Id = product11.Id, Name = "Amazon", Product = product11, City = "Jitomir" };

            Category category12 = new Category() { Id = 12, Name = "Transport" };
            Product product12 = new Product() { Category = category12, Cost = 10000, Name = "Car", Id = category12.Id };
            Provider provider12 = new Provider() { City = "Vegas", Id = product12.Id, Name = "Ebay", Product = product12 };



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
            // context.Categories.AddRange(categories);

            foreach (Provider provider in providers)
            {
                // Console.WriteLine("category: " + provider.Product.Category.Name);
            }

            //context.Entry(products).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}