using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInfo;

namespace CodeFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShopContext context = new ShopContext())
            {
                foreach (var product in context.Products)
                {
                    Console.WriteLine(product.Name);
                }

                //foreach (var category in context.Categories)
                //{
                //    Console.WriteLine(category.Name);
                //}
            }

            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
