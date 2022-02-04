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
	public partial class ProductSalesFor1997Service :GenericService<ProductSalesFor1997>, IProductSalesFor1997Service
    {
		public ProductSalesFor1997Service(IProductSalesFor1997Repository repository) : base(repository)
        {
        }
		public ProductSalesFor1997Repository _repository { get { return _repository as ProductSalesFor1997Repository; } }

	}
}
