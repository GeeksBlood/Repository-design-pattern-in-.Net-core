using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interface
{
    public interface IGenericRepostory<T> where T : class
    {
        IQueryable<T> Get();
        T GetByID(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
