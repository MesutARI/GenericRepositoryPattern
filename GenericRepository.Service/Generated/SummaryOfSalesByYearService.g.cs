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
	public partial class SummaryOfSalesByYearService :GenericService<SummaryOfSalesByYear>, ISummaryOfSalesByYearService
    {
		public SummaryOfSalesByYearService(ISummaryOfSalesByYearRepository repository) : base(repository)
        {
        }
		public SummaryOfSalesByYearRepository _repository { get { return _repository as SummaryOfSalesByYearRepository; } }

	}
}
