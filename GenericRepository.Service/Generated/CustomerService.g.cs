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
	public partial class CustomerService :GenericService<Customer>, ICustomerService
    {
		public CustomerService(ICustomerRepository repository) : base(repository)
        {
        }
		public CustomerRepository _repository { get { return _repository as CustomerRepository; } }

	}
}
