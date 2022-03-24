using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ETicaretAPIDbContext : DbContext
    {
        public ETicaretAPIDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //Burada yapacağımız işlem gelen isteklerde yni insert de createdate dolduracak update'lerde updatedate dolduracak
        // Interceptor işlemi araya girme işlemidir

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //saveCahnge çalıştığında aşağıdaki işlemler gerçekleşecektir.
            // ChangeTracker : Entityler üzerinde yapılan değişiklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertilerdir.update operasyonlarında   track edilen verileri yakalayıp elde etmemizi sağlar.
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                 _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,

                };

            }


            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
