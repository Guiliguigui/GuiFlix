using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> Create(T entity);
        Task<T> Find(int id);
        Task<T> Find(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindAll();
        Task<IEnumerable<T>> FindRandom(int quantity);
        Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate);
        Task<T> Update(T entity);
        Task<bool> Delete(int id);
    }
}
