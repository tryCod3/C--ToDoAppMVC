using System.Collections.Generic;
using DBconfig.Models;

namespace Infrastructure.Interface
{
    public interface IRepositoryTodo : IRepositoryBase<Todo>
    {
        // code tính năng riêng của todo
        IEnumerable<Todo> GetAll();

        int getIdMax();
    }
}
