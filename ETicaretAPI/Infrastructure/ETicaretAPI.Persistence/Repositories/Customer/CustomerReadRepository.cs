using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{

    //Burada yapmak istediğimz  ReadRepository içinde ne kadar metod varsa CustomerReadRepository uygulamış olacaktır ICustomerReadRepository kullanmamızın nedeni ise CustomerReadRepository abstrac class dır yani imzasıdır 
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
