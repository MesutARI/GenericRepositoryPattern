using GenericRepository.Core.Repositories;
using GenericRepository.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        #region variables

        private readonly IGenericRepository<T> _genericRepository;

        #endregion

        #region GenericService
        public GenericService(IGenericRepository<T> genericRepository)
        {
            this._genericRepository = genericRepository;
        }


        #endregion

        #region Methods

        #region GetAll
        public GenericResponse<IEnumerable<T>> GetAll()
        {
            try
            {
                IEnumerable<T> t = this._genericRepository.GetAll();

                return new GenericResponse<IEnumerable<T>>(t);
            }
            catch (Exception ex)
            {
                return new GenericResponse<IEnumerable<T>>($"Fail:: {ex.Message}");
            }
        }

        public async Task<GenericResponse<IEnumerable<T>>> GetAllAsync()
        {
            try
            {
                IEnumerable<T> t = await this._genericRepository.GetAllAsync();

                return new GenericResponse<IEnumerable<T>>(t);
            }
            catch (Exception ex)
            {
                return new GenericResponse<IEnumerable<T>>($"Fail:: {ex.Message}");
            }
        }
        #endregion

        #region GetById
        public GenericResponse<T> GetById(int id)
        {
            try
            {
                T t = this._genericRepository.GetById(id);
                if (t != null)
                    return new GenericResponse<T>(t);
                else
                    return new GenericResponse<T>("!!! This Id does not exist");
            }
            catch (Exception ex)
            {

                return new GenericResponse<T>($"Fail:: {ex.Message}");
            }
        }

        public async Task<GenericResponse<T>> GetByIdAsync(int id)
        {
            try
            {
                T t = await this._genericRepository.GetByIdAsync(id);
                if (t != null)
                    return new GenericResponse<T>(t);
                else
                    return new GenericResponse<T>("!!! This Id does not exist");
            }
            catch (Exception ex)
            {

                return new GenericResponse<T>($"Fail:: {ex.Message}");
            }
        }
        #endregion

        #region CountWhere
        public int CountWhere(Expression<Func<T, bool>> predicate)
        {
            return this._genericRepository.CountWhere(predicate);
        }

        public async Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await this._genericRepository.CountWhereAsync(predicate);

        }
        #endregion

        #region GetWhere
        public GenericResponse<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            try
            {
                IEnumerable<T> t = this._genericRepository.GetWhere(predicate);
                
                return new GenericResponse<IEnumerable<T>>(t);
            }
            catch (Exception ex)
            {
                return new GenericResponse<IEnumerable<T>>($"Fail:: {ex.Message}");
            }
        }

        public async Task<GenericResponse<IEnumerable<T>>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                IEnumerable<T> t = await this._genericRepository.GetWhereAsync(predicate);

                return new GenericResponse<IEnumerable<T>>(t);
            }
            catch (Exception ex)
            {
                return new GenericResponse<IEnumerable<T>>($"Fail:: {ex.Message}");
            }
        }
        #endregion

        #region Add
        public GenericResponse<T> Add(T Entry)
        {
            try
            {
                this._genericRepository.Add(Entry);
                //this._unitOfWork.Complete();

                return new GenericResponse<T>(Entry);

            }
            catch (Exception ex)
            {

                return new GenericResponse<T>($"Fail:: {ex.Message}");
            }
        }

        public async Task<GenericResponse<T>> AddAsync(T Entry)
        {
            try
            {
                await this._genericRepository.AddAsync(Entry);
                //await this._unitOfWork.CompleteAsync();

                return new GenericResponse<T>(Entry);

            }
            catch (Exception ex)
            {

                return new GenericResponse<T>($"Fail:: {ex.Message}");
            }
        }
        #endregion

        #region Delete
        public GenericResponse<T> Delete(int id)
        {
            try
            {
                T t = this._genericRepository.GetById(id);

                if (t != null)
                {
                    this._genericRepository.Delete(id);
                    //this._unitOfWork.Complete();
                    return new GenericResponse<T>(t);
                }
                else
                {
                    return new GenericResponse<T>("This Id does not exist");
                }

            }
            catch (Exception ex)
            {

                return new GenericResponse<T>($"Fail:: {ex.Message}");
            }
        }

        public async Task<GenericResponse<T>> DeleteAsync(int id)
        {
            try
            {
                T t = await this._genericRepository.GetByIdAsync(id);

                if (t != null)
                {
                    await this._genericRepository.DeleteAsync(id);
                    //await this._unitOfWork.CompleteAsync();
                    return new GenericResponse<T>(t);
                }
                else
                {
                    return new GenericResponse<T>("This Id does not exist");
                }

            }
            catch (Exception ex)
            {

                return new GenericResponse<T>($"Fail:: {ex.Message}");
            }
        }
        #endregion

        #region Update
        public GenericResponse<T> Update(T Entry)
        {
            try
            {
                this._genericRepository.Update(Entry);
                //this._unitOfWork.CompleteAsync();

                return new GenericResponse<T>(Entry);
            }
            catch (Exception ex)
            {
                return new GenericResponse<T>($"Fail:: {ex.Message}");

            }
        }

        public async Task<GenericResponse<T>> UpdateAsync(T Entry)
        {
            try
            {
                await this._genericRepository.UpdateAsync(Entry);
                //this._unitOfWork.CompleteAsync();

                return new GenericResponse<T>(Entry);
            }
            catch (Exception ex)
            {
                return new GenericResponse<T>($"Fail:: {ex.Message}");

            }
        }
        #endregion

        #endregion
    }
}
