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
	public partial class SalesByCategoryService :GenericService<SalesByCategory>, ISalesByCategoryService
    {
		public SalesByCategoryService(ISalesByCategoryRepository repository) : base(repository)
        {
        }
		public SalesByCategoryRepository _repository { get { return _repository as SalesByCategoryRepository; } }

	}
}
