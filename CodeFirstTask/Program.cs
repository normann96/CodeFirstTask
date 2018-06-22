using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
           // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ShopContext>());
            using (ShopContext context = new ShopContext())
            {
                //context.Database.Initialize(true);

                foreach (var product in context.Products)
                {
                    Console.WriteLine(product.Name);
                }

                foreach (var category in context.Categories)
                {
                    Console.WriteLine(category.Name);
                }
                Console.WriteLine("done");
                Console.Read();
            }
            
        }
    }
}
