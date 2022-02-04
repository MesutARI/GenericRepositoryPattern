using System;
using System.Threading.Tasks;

namespace GenericRepository.Core.UnitOfWorks
{
    public partial interface IUnitOfWork : IDisposable
    {

        Task CompleteAsync();

        void Complete();
    }
}
