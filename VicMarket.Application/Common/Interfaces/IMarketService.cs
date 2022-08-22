using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Dtos;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IMarketService : IEntityCRUDService<Market, MarketDto>
    {
        List<Market> GetAllMarkets();

        Market CreateMarket(Market market);

        Market DeleteMarket(Market marketId);
    }
}
