using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using Repository.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class GenericRepostory<T> : IGenericRepostory<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        public GenericRepostory(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
       

        public IQueryable<T> Get()
        {
            return _unitOfWork.Context.Set<T>().AsQueryable<T>();
        }

        public T GetByID(int id)
        {
            return _unitOfWork.Context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
        }
        public void Add(T entity)
        {
            _unitOfWork.Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _unitOfWork.Context.Set<T>().Remove(entity);
        }
    }
}
