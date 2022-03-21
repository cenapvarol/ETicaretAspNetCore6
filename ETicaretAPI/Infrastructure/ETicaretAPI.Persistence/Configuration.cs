using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence
{
     static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                //Burada .Net 6 da bir özellik geldi ConfigurationManager bu özelliği kullanarak Presentation katmanında buluna appsettings.json dosyasına eklediğimiz postgrqsl connectin stitrg erişmemiz için kullanacağız. ConfigurationManager işlemini yapabilmemiz için nuget package yükelememiz gerekiyor paket ismi Microsoft.Extensions.Configuration gelin şimdi bu yazdıklarımız yapalım
                ConfigurationManager configurationManager = new();

                //Burada ConfigurationManager nesnesi üzerinde başka bir katmandaki json dosyasına erişim sağlıyacağımızdan dolayı ConfigurationManager.AddJsonFile bunu kullanabilmemiz için Microsoft.Extensions.Configuration.json paketini kurmamız gerekiyor gelin şimdi bunu yapalım.
                //Burada yapılan işlem appsettings.json dosyasının bulunduğu kalsörü belirtiyoruz yani yolun söylüyoruz.
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                //Burada yaptığımız işlem onfigurationManager.GetConnectionString metodunu kullanarak  appsettings.json tanımlamış olduğumuz  PostgreSQL ekliyooruz aşağıdaki gibi
                return configurationManager.GetConnectionString("PostgreSQL");


            }
        }
    }
}
