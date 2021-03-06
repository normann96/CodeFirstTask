﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInfo
{
    public class BusinessLogic
    {
        public static IEnumerable<Product> GetProductsByCategory(string category)
        {
            using (var context = new ShopContext())
            {
                var query = context.Products.Where(x => x.Category.Name == category);
                return query.Any()
                    ? query.ToList()
                    : throw new NullReferenceException("No products with that category!");
            }
        }

        public static IEnumerable<Provider> GetProvidersByCategory(string category)
        {
            using (var context = new ShopContext())
            {
                var query = context.Providers.Where(x => x.Product.Category.Name == category);
                return query.Any() ? query.ToList() : throw new NullReferenceException("No providers for this category!");
            }
        }

        public static IEnumerable<Product> GetProductsListByProvider(string provider)
        {
            using (var context = new ShopContext())
            {
                var query = context.Providers.Where(x => x.Name == provider).Select(u => u.Product);
                return query.Any() ? query.ToList() : throw new NullReferenceException("This provider has not products!");
            }
        }

        public static IEnumerable<Product> GetProductsWhichCost(int cost)
        {
            using (var context = new ShopContext())
            {
                var query = context.Products.Where(x => x.Cost == cost);
                return query.Any() ? query.ToList() : throw new NullReferenceException("No products with that cost");
            }
        }

        public static IEnumerable<Product> GetProductWithMaxCost()
        {
            using (var context = new ShopContext())
            {
                decimal max = context.Products.Max(x => x.Cost);
                var t = context.Products.Select(x => x.Cost);
                Console.WriteLine("TYPE = " + t.GetType());
                return context.Products.Where(u => u.Cost == max).ToList();
            }
        }

        public static IEnumerable<Product> GetProductWithMinCost()
        {
            using (var context = new ShopContext())
            {
                decimal min = context.Products.Min(x => x.Cost);
                return context.Products.Where(u => u.Cost == min).ToList();
            }
        }

        public static IEnumerable<Provider> GetProvidersByCity(string city)
        {
            using (var context = new ShopContext())
            {
                var query = context.Providers.Where(x => x.City == city).ToList();
                return query.Any() ? query.ToList() : throw new NullReferenceException("No providers in this city!");
            }
        }
    }
}
