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
	public partial class CategorySalesFor1997Service :GenericService<CategorySalesFor1997>, ICategorySalesFor1997Service
    {
		public CategorySalesFor1997Service(ICategorySalesFor1997Repository repository) : base(repository)
        {
        }
		public CategorySalesFor1997Repository _repository { get { return _repository as CategorySalesFor1997Repository; } }

	}
}
