using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VicMarket.Application.Common.Interfaces;
using VicMarket.Application.Dtos;
using VicMarket.Domain.Entities;
using VicMarket.Infrastructure.Contexts.VicMarket;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BarberVic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        public static Market market = new Market();
        private readonly IConfiguration _configuration;
        private readonly IMarketService _service;
        private readonly IHttpContextAccessor _accesor;
        private readonly VicMarketDbContext Context;



        public MarketController(IConfiguration configuration, IMarketService service, IHttpContextAccessor accessor, VicMarketDbContext dataContext)
        {
            Context = dataContext;
            _configuration = configuration;
            _service = service;
            _accesor = accessor;

        }
        [HttpGet]
        public async Task<ActionResult<List<Market>>> Get()
        {
            return Ok(await Context.Markets.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Market>> Get(int id)
        {
            var market = await Context.Markets.FindAsync(id);
            if (market == null)
                return BadRequest("Market not found");
            return Ok(market);
        }

        [HttpPost]
        public async Task<ActionResult<List<Market>>> AddMarkets([FromForm] MarketDto request)
        {

            market.MarketName = request.MarketName;
            market.Location = request.Location;


            PostMarket(market);

            return Ok(market);
        }

        private Market PostMarket(Market market)
        {

            var marketFromService = _service.CreateMarket(market);
            return marketFromService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Market>>> UpdateMarkets(int id, [FromForm] MarketDto request)
        {
            var market = await Context.Markets.FindAsync(id);
            if (market == null)
                return BadRequest("Market not found.");

            market.MarketName = request.MarketName;
            market.MarketName = request.MarketName;
            market.Location = request.Location;



            await Context.SaveChangesAsync();

            return Ok(await Context.Markets.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Market>>> Delete(int id)
        {
            var market = await Context.Markets.FindAsync(id);
            if (market == null)
                return BadRequest("Market not found");

            Context.Markets.Remove(market);
            await Context.SaveChangesAsync();
            return Ok(await Context.Markets.ToListAsync());
        }
    }
}
