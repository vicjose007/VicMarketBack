using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();

        Product CreateProduct(Product product);

        Product DeleteProduct(Product productId);
    }
}
