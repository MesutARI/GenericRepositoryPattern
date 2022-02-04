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
	public partial class CurrentProductListService :GenericService<CurrentProductList>, ICurrentProductListService
    {
		public CurrentProductListService(ICurrentProductListRepository repository) : base(repository)
        {
        }
		public CurrentProductListRepository _repository { get { return _repository as CurrentProductListRepository; } }

	}
}
