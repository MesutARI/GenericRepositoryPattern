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
	public partial class CustomerAndSuppliersByCityService :GenericService<CustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
		public CustomerAndSuppliersByCityService(ICustomerAndSuppliersByCityRepository repository) : base(repository)
        {
        }
		public CustomerAndSuppliersByCityRepository _repository { get { return _repository as CustomerAndSuppliersByCityRepository; } }

	}
}
