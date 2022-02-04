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
	public partial class CategoryService :GenericService<Category>, ICategoryService
    {
		public CategoryService(ICategoryRepository repository) : base(repository)
        {
        }
		public CategoryRepository _repository { get { return _repository as CategoryRepository; } }

	}
}
