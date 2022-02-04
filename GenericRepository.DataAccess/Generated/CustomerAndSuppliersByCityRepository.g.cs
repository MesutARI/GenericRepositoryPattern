// 
// This is an auto generated file. 
// Do not make manual change
//  

using GenericRepository.DataAccess.Contexts;
using GenericRepository.Core.Models;
using GenericRepository.Core.Repositories;


namespace GenericRepository.DataAccess.Repositories
{
	public partial class CustomerAndSuppliersByCityRepository : GenericRepository<CustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityRepository
    {
		public CustomerAndSuppliersByCityRepository(NorthwindContext context) : base(context)
        {
        }
		public NorthwindContext _context { get { return _context as NorthwindContext; } }
	}
}
