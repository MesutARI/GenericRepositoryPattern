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
	public partial class SummaryOfSalesByQuarterService :GenericService<SummaryOfSalesByQuarter>, ISummaryOfSalesByQuarterService
    {
		public SummaryOfSalesByQuarterService(ISummaryOfSalesByQuarterRepository repository) : base(repository)
        {
        }
		public SummaryOfSalesByQuarterRepository _repository { get { return _repository as SummaryOfSalesByQuarterRepository; } }

	}
}
