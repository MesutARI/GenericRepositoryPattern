using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericRepository.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        T GetById(int id);
        Task<T> GetByIdAsync(int id);

        int CountWhere(Expression<Func<T, bool>> predicate);
        Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);

        void Add(T Entry);
        Task AddAsync(T Entry);

        void Update(T Entry);
        Task UpdateAsync(T Entry);

        void Delete(int id);
        Task DeleteAsync(int id);

    }
}
