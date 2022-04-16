using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Interface;


namespace Infrastructure.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        private List<T> _list;

     
        public List<T> getListTodo()
        {
            if (_list == null)
                _list = new List<T>();
            return _list;
        }

        public T Create(T model)
        {
            try
            {
                if(model == null)
                    return null;
                getListTodo().Add(model);
                return model;
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        public T Delete(T model)
        {
            if (model == null)
                return null;
            T entity = Get(model);
            if (entity == null) { return null; }
            getListTodo().Remove(entity);
            return model;
        }

        public T Get(T model)
        {
            if (model == null)
                return null;
            T _model = getListTodo().Find(todo => todo.Equals(model));
            return _model;
        }

        public T Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
