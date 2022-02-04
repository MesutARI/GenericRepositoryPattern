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
	public partial class QuarterlyOrderService :GenericService<QuarterlyOrder>, IQuarterlyOrderService
    {
		public QuarterlyOrderService(IQuarterlyOrderRepository repository) : base(repository)
        {
        }
		public QuarterlyOrderRepository _repository { get { return _repository as QuarterlyOrderRepository; } }

	}
}
