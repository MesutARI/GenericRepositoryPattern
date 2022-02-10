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
	public partial class UserService :GenericService<User>, IUserService
    {
		public UserService(IUserRepository repository) : base(repository)
        {
        }
		public UserRepository _repository { get { return _repository as UserRepository; } }

	}
}
