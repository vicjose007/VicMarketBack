using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Dtos;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IBrandService : IEntityCRUDService<Brand, BrandDto>
    {
        List<Brand> GetAllBrands();

        Brand CreateBrand(Brand brand);

        Brand DeleteBrand(Brand brandId);
    }
}
