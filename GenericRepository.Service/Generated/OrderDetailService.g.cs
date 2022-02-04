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
	public partial class OrderDetailService :GenericService<OrderDetail>, IOrderDetailService
    {
		public OrderDetailService(IOrderDetailRepository repository) : base(repository)
        {
        }
		public OrderDetailRepository _repository { get { return _repository as OrderDetailRepository; } }

	}
}
