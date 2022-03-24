using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T>:IRepository<T> where T : BaseEntity
    {
        //burada kullanmış olduğumuz  tracking komut şu işleme yarıyor methot üzerinde yapacağın updet delet işlemri için sistem tracking yani izleme yapar  seni update mi yoksa delet mi yaptığını  tracking  bakarak anlar  yani maliyetli olduğundan dolayı selectlerde mümkün olduğunca  tracking kullanmamaya dikkat ederiz.

        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
