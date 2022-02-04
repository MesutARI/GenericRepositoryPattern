using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Core.Services
{
    public interface IGenericService<T> where T : class
    {
        GenericResponse<IEnumerable<T>> GetAll();
        Task<GenericResponse<IEnumerable<T>>> GetAllAsync();

        GenericResponse<T> GetById(int id);
        Task<GenericResponse<T>> GetByIdAsync(int id);

        int CountWhere(Expression<Func<T, bool>> predicate);
        Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate);

        GenericResponse<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
        Task<GenericResponse<IEnumerable<T>>> GetWhereAsync(Expression<Func<T, bool>> predicate);

        GenericResponse<T> Add(T Entry);
        Task<GenericResponse<T>> AddAsync(T Entry);

        GenericResponse<T> Update(T Entry);
        Task<GenericResponse<T>> UpdateAsync(T Entry);

        GenericResponse<T> Delete(int id);
        Task<GenericResponse<T>> DeleteAsync(int id);

    }
}
