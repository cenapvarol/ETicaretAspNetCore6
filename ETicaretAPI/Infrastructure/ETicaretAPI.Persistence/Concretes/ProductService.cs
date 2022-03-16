using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new() { ID = Guid.NewGuid(), Name = "Product 1", Stock = 100, Price = 20 },
                new() { ID = Guid.NewGuid(), Name = "Product 2", Stock = 200, Price = 30 },
                new() { ID = Guid.NewGuid(), Name = "Product 3", Stock = 300, Price = 40 },
                new() { ID = Guid.NewGuid(), Name = "Product 4", Stock = 400, Price = 50 },
                new() { ID = Guid.NewGuid(), Name = "Product 5", Stock = 500, Price = 60 },
                new() { ID = Guid.NewGuid(), Name = "Product 6", Stock = 600, Price = 70 },
                new() { ID = Guid.NewGuid(), Name = "Product 7", Stock = 700, Price = 80 }
            };
    }
}
