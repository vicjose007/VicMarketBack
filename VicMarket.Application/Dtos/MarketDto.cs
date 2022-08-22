using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntityDto;

namespace VicMarket.Application.Dtos
{
    public class MarketDto : BaseEntityDto
    {
        public string MarketName { get; set; }

        public string Location { get; set; }
    }
}
