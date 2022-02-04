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
	public partial class ProductService :GenericService<Product>, IProductService
    {
		public ProductService(IProductRepository repository) : base(repository)
        {
        }
		public ProductRepository _repository { get { return _repository as ProductRepository; } }

	}
}
