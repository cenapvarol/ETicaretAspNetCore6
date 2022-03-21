using ETicaretAPI.Persistence.Concretes;
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
        }
    }
}
