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
	public partial class SalesTotalsByAmountService :GenericService<SalesTotalsByAmount>, ISalesTotalsByAmountService
    {
		public SalesTotalsByAmountService(ISalesTotalsByAmountRepository repository) : base(repository)
        {
        }
		public SalesTotalsByAmountRepository _repository { get { return _repository as SalesTotalsByAmountRepository; } }

	}
}
