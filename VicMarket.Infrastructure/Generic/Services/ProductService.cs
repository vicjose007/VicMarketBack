using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Common.Interfaces;
using VicMarket.Application.Dtos;
using VicMarket.Domain.Entities;
using VicMarket.Infrastructure.Contexts.VicMarket;
using VicMarket.Infrastructure.UnitOfWorks;

namespace VicMarket.Infrastructure.Generic.Services
{
    public class ProductService : EntityCRUDService<Product, ProductDto>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IMapper mapper, IUnitOfWork<IVicMarketDbContext> uow, IProductRepository productRepository) : base(mapper, uow)
        {
            _productRepository = productRepository;
        }
        public Product CreateProduct(Product product)
        {
            _productRepository.CreateProduct(product);
            return product;
        }

        public Product DeleteProduct(Product product)
        {
            _productRepository.DeleteProduct(product);
            return product;
        }

        public List<Product> GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return products;
        }
    }
}
