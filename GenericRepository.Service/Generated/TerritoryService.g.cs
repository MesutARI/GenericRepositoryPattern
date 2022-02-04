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
	public partial class TerritoryService :GenericService<Territory>, ITerritoryService
    {
		public TerritoryService(ITerritoryRepository repository) : base(repository)
        {
        }
		public TerritoryRepository _repository { get { return _repository as TerritoryRepository; } }

	}
}
