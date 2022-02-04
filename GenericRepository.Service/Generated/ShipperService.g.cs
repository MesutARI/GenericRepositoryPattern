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
	public partial class ShipperService :GenericService<Shipper>, IShipperService
    {
		public ShipperService(IShipperRepository repository) : base(repository)
        {
        }
		public ShipperRepository _repository { get { return _repository as ShipperRepository; } }

	}
}
