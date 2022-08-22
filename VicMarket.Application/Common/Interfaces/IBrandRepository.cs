using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IBrandRepository
    {
        List<Brand> GetAllBrands();

        Brand CreateBrand(Brand brand);

        Brand DeleteBrand(Brand brandId);
    }
}
