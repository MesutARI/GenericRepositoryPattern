

// 
// This is an auto generated file. 
// Do not make manual change
//  
using System;
using System.Threading.Tasks;
using GenericRepository.Core.Models;
using GenericRepository.Core.Services;

namespace GenericRepository.Core.UnitOfWorks
{
	public partial interface IUnitOfWork : IDisposable
    {
				IAlphabeticalListOfProductService AlphabeticalListOfProductServices { get; }
				ICategoryService CategoryServices { get; }
				ICategorySalesFor1997Service CategorySalesFor1997Services { get; }
				ICurrentProductListService CurrentProductListServices { get; }
				ICustomerService CustomerServices { get; }
				ICustomerAndSuppliersByCityService CustomerAndSuppliersByCityServices { get; }
				ICustomerCustomerDemoService CustomerCustomerDemoServices { get; }
				ICustomerDemographicService CustomerDemographicServices { get; }
				IEmployeeService EmployeeServices { get; }
				IEmployeeTerritoryService EmployeeTerritoryServices { get; }
				IInvoiceService InvoiceServices { get; }
				IOrderService OrderServices { get; }
				IOrderDetailService OrderDetailServices { get; }
				IOrderDetailsExtendedService OrderDetailsExtendedServices { get; }
				IOrdersQryService OrdersQryServices { get; }
				IOrderSubtotalService OrderSubtotalServices { get; }
				IProductService ProductServices { get; }
				IProductsAboveAveragePriceService ProductsAboveAveragePriceServices { get; }
				IProductSalesFor1997Service ProductSalesFor1997Services { get; }
				IProductsByCategoryService ProductsByCategoryServices { get; }
				IQuarterlyOrderService QuarterlyOrderServices { get; }
				IRegionService RegionServices { get; }
				ISalesByCategoryService SalesByCategoryServices { get; }
				ISalesTotalsByAmountService SalesTotalsByAmountServices { get; }
				IShipperService ShipperServices { get; }
				ISummaryOfSalesByQuarterService SummaryOfSalesByQuarterServices { get; }
				ISummaryOfSalesByYearService SummaryOfSalesByYearServices { get; }
				ISupplierService SupplierServices { get; }
				ITerritoryService TerritoryServices { get; }
		
		
	}
}
