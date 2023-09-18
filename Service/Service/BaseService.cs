using Infrastructure.DB;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System.Linq.Expressions;

namespace Service.Service
{
    public abstract class BaseService<T> : IBaseService<T> where T : class
    {
        protected ApplicationDbContext _applicationDbContext;
        protected readonly DbSet<T> _dbSet;

        public BaseService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _dbSet = _applicationDbContext.Set<T>();
        }

        public T Add(T entity)
        {
            _applicationDbContext.Entry(entity).State = EntityState.Added;

            var result = _dbSet.Add(entity);

            return result.Entity;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                _applicationDbContext.Entry(entity).State = EntityState.Added;

            _dbSet.AddRange(entities);
        }

        public void Delete(T entity)
        {
            _applicationDbContext.Entry(entity).State = EntityState.Deleted;

            _dbSet.Remove(entity);
        }

        public void Delete(Guid id)
        {
            var entity = GetById(id);

            if (entity == null)
                throw new Exception();

            _applicationDbContext.Entry(entity).State = EntityState.Deleted;

            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                _applicationDbContext.Entry(entity).State = EntityState.Deleted;

            _dbSet.RemoveRange(entities);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IQueryable<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter);
        }

        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public T Update(T entity)
        {
            _applicationDbContext.Entry(entity).State = EntityState.Modified;

            T entity1 = _dbSet.Update(entity).Entity;

            return entity;
        }

        public IEnumerable<T> GetAll(bool AsNoTracking)
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public void Commit()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
