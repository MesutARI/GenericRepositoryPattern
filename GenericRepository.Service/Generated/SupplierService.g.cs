// 
// This is an auto generated file. 
// Do not make manual change
//  

using GenericRepository.Core.Models;
using GenericRepository.Core.Repositories;
using GenericRepository.Core.Services;
using GenericRepository.DataAccess.Repositories;

namespace GenericRepository.Service.Services
{
	public partial class SupplierService :GenericService<Supplier>, ISupplierService
    {
		public SupplierService(ISupplierRepository repository) : base(repository)
        {
        }
		public SupplierRepository _repository { get { return _repository as SupplierRepository; } }

	}
}
