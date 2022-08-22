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
    public class BrandController : ControllerBase
    {
        public static Brand brand = new Brand();
        private readonly IConfiguration _configuration;
        private readonly IBrandService _service;
        private readonly IHttpContextAccessor _accesor;
        private readonly VicMarketDbContext Context;



        public BrandController(IConfiguration configuration, IBrandService service, IHttpContextAccessor accessor, VicMarketDbContext dataContext)
        {
            Context = dataContext;
            _configuration = configuration;
            _service = service;
            _accesor = accessor;

        }
        [HttpGet]
        public async Task<ActionResult<List<Brand>>> Get()
        {
            return Ok(await Context.Brands.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> Get(int id)
        {
            var brand = await Context.Brands.FindAsync(id);
            if (brand == null)
                return BadRequest("Brand not found");
            return Ok(brand);
        }

        [HttpPost]
        public async Task<ActionResult<List<Brand>>> AddBrands([FromForm] BrandDto request)
        {

            brand.BrandName = request.BrandName;
            brand.Details = request.Details;


            PostBrand(brand);

            return Ok(brand);
        }

        private Brand PostBrand(Brand brand)
        {

            var brandFromService = _service.CreateBrand(brand);
            return brandFromService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Brand>>> UpdateBrands(int id, [FromForm] BrandDto request)
        {
            var brand = await Context.Brands.FindAsync(id);
            if (brand == null)
                return BadRequest("Brand not found.");

            brand.BrandName = request.BrandName;
            brand.Details = request.Details;



            await Context.SaveChangesAsync();

            return Ok(await Context.Brands.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Brand>>> Delete(int id)
        {
            var brand = await Context.Brands.FindAsync(id);
            if (brand == null)
                return BadRequest("Brand not found");

            Context.Brands.Remove(brand);
            await Context.SaveChangesAsync();
            return Ok(await Context.Brands.ToListAsync());
        }
    }
}
