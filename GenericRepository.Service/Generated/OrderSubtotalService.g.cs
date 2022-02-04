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
	public partial class OrderSubtotalService :GenericService<OrderSubtotal>, IOrderSubtotalService
    {
		public OrderSubtotalService(IOrderSubtotalRepository repository) : base(repository)
        {
        }
		public OrderSubtotalRepository _repository { get { return _repository as OrderSubtotalRepository; } }

	}
}
