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
	public partial class ProductsByCategoryService :GenericService<ProductsByCategory>, IProductsByCategoryService
    {
		public ProductsByCategoryService(IProductsByCategoryRepository repository) : base(repository)
        {
        }
		public ProductsByCategoryRepository _repository { get { return _repository as ProductsByCategoryRepository; } }

	}
}
