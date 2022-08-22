using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntityDto;

namespace VicMarket.Application.Dtos
{
    public class ShoppingListDto : BaseEntityDto
    {
        public int UserId { get; set; }

        public int BrandId { get; set; }

        public int MarketId { get; set; }

        public int ProductId { get; set; }
    }
}
