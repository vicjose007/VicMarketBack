using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntityDto;

namespace VicMarket.Application.Dtos
{
    public class BrandDto : BaseEntityDto
    {
        public string BrandName { get; set; }

        public string Details { get; set; }
    }
}
