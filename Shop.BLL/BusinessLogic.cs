using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.BLL
{
    public class BusinessLogic : IDisposable
    {
        readonly ShopContext _context = new ShopContext();
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            //var query = _context.Products.Where(x => x.Category.Name == category);
            //return query.Any()
            //    ? query.ToList()
            //    : null;

            return _context.Products.Where(x => x.Category.Name == category).ToList();
        }

        public IEnumerable<Provider> GetProvidersByCategory(string category)
        {
            //var query = _context.Providers.Where(x => x.Product.Category.Name == category);
            //return query.Any() ? query.ToList() : null;
            return _context.Providers.Where(x => x.Product.Category.Name == category).ToList();
        }

        public IEnumerable<Product> GetProductsListByProvider(string provider)
        {
            //var query = _context.Providers.Where(x => x.Name == provider).Select(u => u.Product);
            //return query.Any() ? query.ToList() : null;

            return _context.Providers.Where(x => x.Name == provider).Select(u => u.Product).ToList();
        }

        public IEnumerable<Product> GetProductsWhichCost(decimal cost)
        {
            //var query = _context.Products.Where(x => x.Cost == cost);
            //return query.Any() ? query.ToList() : null;

            return _context.Products.Where(x => x.Cost == cost).ToList();
        }

        public IEnumerable<Product> GetProductWithMaxCost()
        {
            decimal max = _context.Products.Max(x => x.Cost);
            return _context.Products.Where(u => u.Cost == max).ToList();
        }

        public IEnumerable<Product> GetProductWithMinCost()
        {
            decimal min = _context.Products.Min(x => x.Cost);
            return _context.Products.Where(u => u.Cost == min).ToList();
        }

        public IEnumerable<Provider> GetProvidersByCity(string city)
        {
            //var query = _context.Providers.Where(x => x.City == city).ToList();
            //return query.Any() ? query.ToList() : null;

            return _context.Providers.Where(x => x.City == city).ToList();
        }

        public void AddProduct(Product product)
        {

        }

        public void RemoveProduct()
        {

        }

        public void UpdateProduct()
        {

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
