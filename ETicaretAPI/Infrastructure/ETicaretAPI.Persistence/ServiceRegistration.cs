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
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);
            //Burada yapılan işlem Persistence tanımlamış olduğumuz customer,order,product yapılanmaları IOC eklemek   bizden ICustomerReadRepository istediğinde sistem  CustomerReadRepository verecektir 
            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
