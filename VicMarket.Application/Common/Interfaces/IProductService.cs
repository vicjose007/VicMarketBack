using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Dtos;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IProductService : IEntityCRUDService<Product, ProductDto>
    {
        List<Product> GetAllProducts();

        Product CreateProduct(Product product);

        Product DeleteProduct(Product productId);
    }
}
