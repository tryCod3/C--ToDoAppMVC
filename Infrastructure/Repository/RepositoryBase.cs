using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Interface;


namespace Infrastructure.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        private static List<T> ListToDo;

     
        public  List<T> GetListTodo()
        {
            if (ListToDo == null)
                ListToDo = new List<T>();

            return ListToDo;
        }



        public T Create(T model)
        {
            try
            {
                if(model == null)
                    return null;

                GetListTodo().Add(model);
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
            GetListTodo().Remove(entity);
            return model;
        }

        public T Get(T model)
        {
            if (model == null)
                return null;
            T _model = GetListTodo().Find(todo => todo.Equals(model));
            return _model;
        }

        public T Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
