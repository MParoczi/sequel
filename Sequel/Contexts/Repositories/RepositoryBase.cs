using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sequel.Contexts.Contracts;

namespace Sequel.Contexts.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public RepositoryBase(SequelContext sequelContext)
        {
            AppContext = sequelContext;
        }

        private SequelContext AppContext { get; }

        public IQueryable<T> FindAll()
        {
            return AppContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return AppContext.Set<T>().Where(expression).AsNoTracking();
        }

        public async void Create(T entity)
        {
            await AppContext.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            AppContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            AppContext.Set<T>().Remove(entity);
        }
    }
}