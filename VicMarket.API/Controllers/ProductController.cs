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
    public class ProductController : ControllerBase
    {
        public static Product product = new Product();
        private readonly IConfiguration _configuration;
        private readonly IProductService _service;
        private readonly IHttpContextAccessor _accesor;
        private readonly VicMarketDbContext Context;



        public ProductController(IConfiguration configuration, IProductService service, IHttpContextAccessor accessor, VicMarketDbContext dataContext)
        {
            Context = dataContext;
            _configuration = configuration;
            _service = service;
            _accesor = accessor;

        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return Ok(await Context.Products.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var product = await Context.Products.FindAsync(id);
            if (product == null)
                return BadRequest("Product not found");
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProducts([FromForm] ProductDto request)
        {

            product.ProductName = request.ProductName;
            product.Price = request.Price;


            PostProduct(product);

            return Ok(product);
        }

        private Product PostProduct(Product product)
        {

            var productFromService = _service.CreateProduct(product);
            return productFromService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Product>>> UpdateProducts(int id, [FromForm] ProductDto request)
        {
            var product = await Context.Products.FindAsync(id);
            if (product == null)
                return BadRequest("Product not found.");

            product.ProductName = request.ProductName;
            product.Price = request.Price;


            await Context.SaveChangesAsync();

            return Ok(await Context.Products.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Product>>> Delete(int id)
        {
            var product = await Context.Products.FindAsync(id);
            if (product == null)
                return BadRequest("Product not found");

            Context.Products.Remove(product);
            await Context.SaveChangesAsync();
            return Ok(await Context.Products.ToListAsync());
        }
    }
}
