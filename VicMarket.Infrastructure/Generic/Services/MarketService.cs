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
    public class BrandService : EntityCRUDService<Brand, BrandDto>, IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        public BrandService(IMapper mapper, IUnitOfWork<IVicMarketDbContext> uow, IBrandRepository brandRepository) : base(mapper, uow)
        {
            _brandRepository = brandRepository;
        }
        public Brand CreateBrand(Brand brand)
        {
            _brandRepository.CreateBrand(brand);
            return brand;
        }

        public Brand DeleteBrand(Brand brand)
        {
            _brandRepository.DeleteBrand(brand);
            return brand;
        }

        public List<Brand> GetAllBrands()
        {
            var brands = _brandRepository.GetAllBrands();
            return brands;
        }
    }
}
