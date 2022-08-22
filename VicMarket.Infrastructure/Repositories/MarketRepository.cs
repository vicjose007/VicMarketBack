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
    public class MarketRepository : IMarketRepository
    {
        public static List<Market> markets = new List<Market>()
        {

        };
        private readonly VicMarketDbContext _marketDbContext;

        public MarketRepository(VicMarketDbContext marketDbContext)
        {
            _marketDbContext = marketDbContext;
        }
        public Market CreateMarket(Market market)
        {
            _marketDbContext.Markets.Add(market);
            _marketDbContext.SaveChanges();
            return market;
        }

        public Market DeleteMarket(Market market)
        {
            _marketDbContext.Markets.Remove(market);
            _marketDbContext.SaveChanges();
            return null;
        }

        public List<Market> GetAllMarkets()
        {
            return _marketDbContext.Markets.ToList();
        }
    }
}
