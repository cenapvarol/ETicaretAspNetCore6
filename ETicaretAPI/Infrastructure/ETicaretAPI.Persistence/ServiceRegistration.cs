using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Concretes;
using ETicaretAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        //Burada yapılan işlem olşturmuş olduğumuz class'ı static class çeviriyoruz  ardından static fonksiyon oluşturup IOC ekleyebilmemzi için "IServiceCollection" extensions ekleyip  Presentation katmanında program.cs dosyasına IOC ayarlamsı yapıyoruz
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //Burada yaptığımız işlem ise  Configuration.cs dosyasında tanımlamış olduğumuz ayarları burdan çağırıyoruz
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            //Burada yapılan işlem Persistence tanımlamış olduğumuz customer,order,product yapılanmaları IOC eklemek   bizden ICustomerReadRepository istediğinde sistem  CustomerReadRepository verecektir 
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
