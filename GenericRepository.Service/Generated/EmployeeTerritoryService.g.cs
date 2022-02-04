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
	public partial class EmployeeTerritoryService :GenericService<EmployeeTerritory>, IEmployeeTerritoryService
    {
		public EmployeeTerritoryService(IEmployeeTerritoryRepository repository) : base(repository)
        {
        }
		public EmployeeTerritoryRepository _repository { get { return _repository as EmployeeTerritoryRepository; } }

	}
}
