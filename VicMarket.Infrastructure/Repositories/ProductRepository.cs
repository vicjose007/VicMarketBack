using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Common.Interfaces;
using VicMarket.Domain.Entities;
using VicMarket.Infrastructure.Contexts.VicMarket;

namespace VicMarket.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public static List<Product> products = new List<Product>()
        {

        };
        private readonly VicMarketDbContext _productDbContext;

        public ProductRepository(VicMarketDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public Product CreateProduct(Product product)
        {
            _productDbContext.Products.Add(product);
            _productDbContext.SaveChanges();
            return product;
        }

        public Product DeleteProduct(Product product)
        {
            _productDbContext.Products.Remove(product);
            _productDbContext.SaveChanges();
            return null;
        }

        public List<Product> GetAllProducts()
        {
            return _productDbContext.Products.ToList();
        }
    }
}
