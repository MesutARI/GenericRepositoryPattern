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
	public partial class RegionService :GenericService<Region>, IRegionService
    {
		public RegionService(IRegionRepository repository) : base(repository)
        {
        }
		public RegionRepository _repository { get { return _repository as RegionRepository; } }

	}
}
