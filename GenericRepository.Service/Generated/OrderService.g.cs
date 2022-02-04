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
	public partial class OrderService :GenericService<Order>, IOrderService
    {
		public OrderService(IOrderRepository repository) : base(repository)
        {
        }
		public OrderRepository _repository { get { return _repository as OrderRepository; } }

	}
}
