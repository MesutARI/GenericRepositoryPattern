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
	public partial class InvoiceService :GenericService<Invoice>, IInvoiceService
    {
		public InvoiceService(IInvoiceRepository repository) : base(repository)
        {
        }
		public InvoiceRepository _repository { get { return _repository as InvoiceRepository; } }

	}
}
