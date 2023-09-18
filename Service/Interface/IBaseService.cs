using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBaseService<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(bool AsNoTracking);
        T GetById(Guid id);
        IQueryable<T> GetByFilter(Expression<Func<T, bool>> filter);
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        T Update(T entity);
        void Delete(T entity);
        void Delete(Guid id);
        void DeleteRange(IEnumerable<T> entities);

        void Commit();
    }
}
