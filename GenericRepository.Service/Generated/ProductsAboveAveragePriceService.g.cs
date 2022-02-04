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
	public partial class ProductsAboveAveragePriceService :GenericService<ProductsAboveAveragePrice>, IProductsAboveAveragePriceService
    {
		public ProductsAboveAveragePriceService(IProductsAboveAveragePriceRepository repository) : base(repository)
        {
        }
		public ProductsAboveAveragePriceRepository _repository { get { return _repository as ProductsAboveAveragePriceRepository; } }

	}
}
