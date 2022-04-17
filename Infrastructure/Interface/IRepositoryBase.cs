using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IRepositoryBase<T>
    {

        T Get(T id);

        T Create(T entity);

        T Update(T entity);

        T Delete(T id);

    }
}
