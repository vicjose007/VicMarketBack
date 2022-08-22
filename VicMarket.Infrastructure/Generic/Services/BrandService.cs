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
    public class MarketService : EntityCRUDService<Market, MarketDto>, IMarketService
    {
        private readonly IMarketRepository _marketRepository;
        public MarketService(IMapper mapper, IUnitOfWork<IVicMarketDbContext> uow, IMarketRepository marketRepository) : base(mapper, uow)
        {
            _marketRepository = marketRepository;
        }
        public Market CreateMarket(Market market)
        {
            _marketRepository.CreateMarket(market);
            return market;
        }

        public Market DeleteMarket(Market market)
        {
            _marketRepository.DeleteMarket(market);
            return market;
        }

        public List<Market> GetAllMarkets()
        {
            var markets = _marketRepository.GetAllMarkets();
            return markets;
        }
    }
}
