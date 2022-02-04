using GenericRepository.Core.Services;
using GenericRepository.Core.UnitOfWorks;
using System;
using System.Threading.Tasks;

namespace GenericRepository.Service.UnitOfWorks
{
    public partial class UnitOfWork :IUnitOfWork
    {
        #region Complete
        public void Complete()
        {
            this._context.SaveChanges();
        }

        public async Task CompleteAsync()
        {
            await this._context.SaveChangesAsync();
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        #endregion
    }
}
