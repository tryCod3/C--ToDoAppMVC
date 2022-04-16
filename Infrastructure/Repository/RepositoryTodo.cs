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
            int index = 1;
            if(getListTodo().Count > 0)
            {
                return getListTodo().Max(x => x.Id);
            }
            return index;
        }
    }
}
