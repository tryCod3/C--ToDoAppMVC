using System.Linq;
using System.Collections.Generic;
using DBconfig.Models;
using Infrastructure.Interface;

namespace Infrastructure.Repository
{
    public class RepositoryTodo : RepositoryBase<Todo>, IRepositoryTodo
    {
        public IEnumerable<Todo> GetAll()
        {
            return getListTodo();
        }

        public int getIdMax()
        {
            Todo t = getListTodo().OrderByDescending(x => x.Id).FirstOrDefault();
            if (t == null) return 0;
            return t.Id;            
        }
    }
}
