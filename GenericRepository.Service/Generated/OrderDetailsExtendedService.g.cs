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
	public partial class OrderDetailsExtendedService :GenericService<OrderDetailsExtended>, IOrderDetailsExtendedService
    {
		public OrderDetailsExtendedService(IOrderDetailsExtendedRepository repository) : base(repository)
        {
        }
		public OrderDetailsExtendedRepository _repository { get { return _repository as OrderDetailsExtendedRepository; } }

	}
}
