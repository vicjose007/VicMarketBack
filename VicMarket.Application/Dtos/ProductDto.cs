using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntityDto;

namespace VicMarket.Application.Dtos
{
    public class ProductDto : BaseEntityDto
    {
        public string ProductName { get; set; }

        public float Price { get; set; }
    }
}
