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
	public partial class CustomerDemographicService :GenericService<CustomerDemographic>, ICustomerDemographicService
    {
		public CustomerDemographicService(ICustomerDemographicRepository repository) : base(repository)
        {
        }
		public CustomerDemographicRepository _repository { get { return _repository as CustomerDemographicRepository; } }

	}
}
