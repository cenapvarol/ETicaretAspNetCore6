using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        //Burada yapılan işlem olşturmuş olduğumuz class'ı static class çeviriyoruz  ardından static fonksiyon oluşturup IOC ekleyebilmemzi için "IServiceCollection" extensions ekleyip  Presentation katmanında program.cs dosyasına IOC ayarlamsı yapıyoruz
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
