using DBconfig.Models;
using Infrastructure.Interface;
using System.Collections.Generic;

namespace Infrastructure.Repository
{
    public class RepositoryTodo : RepositoryBase<Todo>, IRepositoryTodo
    {
        public IEnumerable<Todo> GetAll()
        {
            return getListTodo();
        }
    }
}
