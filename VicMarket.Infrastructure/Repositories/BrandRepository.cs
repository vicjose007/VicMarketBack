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
    public class BrandRepository : IBrandRepository
    {
        public static List<Brand> brands = new List<Brand>()
        {

        };
        private readonly VicMarketDbContext _brandDbContext;

        public BrandRepository(VicMarketDbContext brandDbContext)
        {
            _brandDbContext = brandDbContext;
        }
        public Brand CreateBrand(Brand brand)
        {
            _brandDbContext.Brands.Add(brand);
            _brandDbContext.SaveChanges();
            return brand;
        }

        public Brand DeleteBrand(Brand brand)
        {
            _brandDbContext.Brands.Remove(brand);
            _brandDbContext.SaveChanges();
            return null;
        }

        public List<Brand> GetAllBrands()
        {
            return _brandDbContext.Brands.ToList();
        }
    }
}
