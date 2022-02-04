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
	public partial class EmployeeService :GenericService<Employee>, IEmployeeService
    {
		public EmployeeService(IEmployeeRepository repository) : base(repository)
        {
        }
		public EmployeeRepository _repository { get { return _repository as EmployeeRepository; } }

	}
}
