using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
          await  _productWriteRepository.AddRangeAsync(new()
            {
                new() { ID = Guid.NewGuid(), Name = "Product 1", Price = 100, CreateDate = DateTime.UtcNow, Stock = 10 },
                new() { ID = Guid.NewGuid(), Name = "Product 2", Price = 200, CreateDate = DateTime.UtcNow, Stock = 15 },
                new() { ID = Guid.NewGuid(), Name = "Product 3", Price = 300, CreateDate = DateTime.UtcNow, Stock = 100 },
                new() { ID = Guid.NewGuid(), Name = "Product 4", Price = 400, CreateDate = DateTime.UtcNow, Stock = 18 },
                new() { ID = Guid.NewGuid(), Name = "Product 5", Price = 500, CreateDate = DateTime.UtcNow, Stock = 190 },
                new() { ID = Guid.NewGuid(), Name = "Product 6", Price = 600, CreateDate = DateTime.UtcNow, Stock = 100 },
                new() { ID = Guid.NewGuid(), Name = "Product 7", Price = 700, CreateDate = DateTime.UtcNow, Stock = 101 },
                new() { ID = Guid.NewGuid(), Name = "Product 8", Price = 800, CreateDate = DateTime.UtcNow, Stock = 105 },
                new() { ID = Guid.NewGuid(), Name = "Product 9", Price = 900, CreateDate = DateTime.UtcNow, Stock = 106 },
                new() { ID = Guid.NewGuid(), Name = "Product 10", Price = 1000, CreateDate = DateTime.UtcNow, Stock = 10 }
            });
           await _productWriteRepository.SaveAsync();
        }
    }
}
