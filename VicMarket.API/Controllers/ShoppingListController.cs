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
    public class ShoppingListController : ControllerBase
    {
        public static ShoppingList shoppingList = new ShoppingList();
        private readonly IConfiguration _configuration;
        private readonly IShoppingListService _service;
        private readonly IHttpContextAccessor _accesor;
        private readonly VicMarketDbContext Context;



        public ShoppingListController(IConfiguration configuration, IShoppingListService service, IHttpContextAccessor accessor, VicMarketDbContext dataContext)
        {
            Context = dataContext;
            _configuration = configuration;
            _service = service;
            _accesor = accessor;

        }
        [HttpGet]
        public async Task<ActionResult<List<ShoppingList>>> Get()
        {
            return Ok(await Context.ShoppingLists
                .Include(c => c.User)
                .Include(c => c.Product)
                .Include(c => c.Brand)
                .Include(c => c.Market).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShoppingList>> Get(int id)
        {
            var shoppingList = await Context.ShoppingLists.FindAsync(id);
            if (shoppingList == null)
                return BadRequest("ShoppingList not found");
            return Ok(shoppingList);
        }

        [HttpPost]
        public async Task<ActionResult<List<ShoppingList>>> AddShoppingLists([FromForm] ShoppingListDto request)
        {
            var user = await Context.Users.FindAsync(request.UserId);
            if (user == null)
                return BadRequest("User not found.");

            var newShoppingList = new ShoppingList
            {
                User = user,
                MarketId = request.MarketId,
                BrandId = request.BrandId,
                ProductId = request.ProductId,


            };

            PostShoppingList(newShoppingList);

            return Ok(newShoppingList);
        }

        private ShoppingList PostShoppingList(ShoppingList shoppingList)
        {

            var shoppingListFromService = _service.CreateShoppingList(shoppingList);
            return shoppingListFromService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ShoppingList>>> UpdateShoppingLists(int id, [FromForm] ShoppingListDto request)
        {
            var shoppingList = await Context.ShoppingLists.FindAsync(id);
            if (shoppingList == null)
                return BadRequest("ShoppingList not found.");

            shoppingList.UserId = request.UserId;
            shoppingList.MarketId = request.MarketId;
            shoppingList.BrandId = request.BrandId;
            shoppingList.ProductId = request.ProductId;


            await Context.SaveChangesAsync();

            return Ok(await Context.ShoppingLists.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ShoppingList>>> Delete(int id)
        {
            var shoppingList = await Context.ShoppingLists.FindAsync(id);
            if (shoppingList == null)
                return BadRequest("ShoppingList not found");

            Context.ShoppingLists.Remove(shoppingList);
            await Context.SaveChangesAsync();
            return Ok(await Context.ShoppingLists.ToListAsync());
        }
    }
}
