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
	public partial class CustomerCustomerDemoService :GenericService<CustomerCustomerDemo>, ICustomerCustomerDemoService
    {
		public CustomerCustomerDemoService(ICustomerCustomerDemoRepository repository) : base(repository)
        {
        }
		public CustomerCustomerDemoRepository _repository { get { return _repository as CustomerCustomerDemoRepository; } }

	}
}
