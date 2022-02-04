

// 
// This is an auto generated file. 
// Do not make manual change
//  
using System;
using System.Threading.Tasks;
using GenericRepository.Core.Repositories;
using GenericRepository.Core.Models;
using GenericRepository.Core.Services;
using GenericRepository.Core.UnitOfWorks;
using GenericRepository.DataAccess.Contexts;
using GenericRepository.DataAccess.Repositories;
using GenericRepository.Service.Services;

namespace GenericRepository.Service.UnitOfWorks
{
	public partial class UnitOfWork : IUnitOfWork
    {
		private NorthwindContext _context = new NorthwindContext();
		
				
		private IAlphabeticalListOfProductRepository _AlphabeticalListOfProductRepository;
        private IAlphabeticalListOfProductRepository AlphabeticalListOfProductRepository => _AlphabeticalListOfProductRepository = _AlphabeticalListOfProductRepository ?? new AlphabeticalListOfProductRepository(_context);
        
		
        private IAlphabeticalListOfProductService _AlphabeticalListOfProductService;
        public IAlphabeticalListOfProductService AlphabeticalListOfProductServices => _AlphabeticalListOfProductService = _AlphabeticalListOfProductService ?? new AlphabeticalListOfProductService(AlphabeticalListOfProductRepository);


				
		private ICategoryRepository _CategoryRepository;
        private ICategoryRepository CategoryRepository => _CategoryRepository = _CategoryRepository ?? new CategoryRepository(_context);
        
		
        private ICategoryService _CategoryService;
        public ICategoryService CategoryServices => _CategoryService = _CategoryService ?? new CategoryService(CategoryRepository);


				
		private ICategorySalesFor1997Repository _CategorySalesFor1997Repository;
        private ICategorySalesFor1997Repository CategorySalesFor1997Repository => _CategorySalesFor1997Repository = _CategorySalesFor1997Repository ?? new CategorySalesFor1997Repository(_context);
        
		
        private ICategorySalesFor1997Service _CategorySalesFor1997Service;
        public ICategorySalesFor1997Service CategorySalesFor1997Services => _CategorySalesFor1997Service = _CategorySalesFor1997Service ?? new CategorySalesFor1997Service(CategorySalesFor1997Repository);


				
		private ICurrentProductListRepository _CurrentProductListRepository;
        private ICurrentProductListRepository CurrentProductListRepository => _CurrentProductListRepository = _CurrentProductListRepository ?? new CurrentProductListRepository(_context);
        
		
        private ICurrentProductListService _CurrentProductListService;
        public ICurrentProductListService CurrentProductListServices => _CurrentProductListService = _CurrentProductListService ?? new CurrentProductListService(CurrentProductListRepository);


				
		private ICustomerRepository _CustomerRepository;
        private ICustomerRepository CustomerRepository => _CustomerRepository = _CustomerRepository ?? new CustomerRepository(_context);
        
		
        private ICustomerService _CustomerService;
        public ICustomerService CustomerServices => _CustomerService = _CustomerService ?? new CustomerService(CustomerRepository);


				
		private ICustomerAndSuppliersByCityRepository _CustomerAndSuppliersByCityRepository;
        private ICustomerAndSuppliersByCityRepository CustomerAndSuppliersByCityRepository => _CustomerAndSuppliersByCityRepository = _CustomerAndSuppliersByCityRepository ?? new CustomerAndSuppliersByCityRepository(_context);
        
		
        private ICustomerAndSuppliersByCityService _CustomerAndSuppliersByCityService;
        public ICustomerAndSuppliersByCityService CustomerAndSuppliersByCityServices => _CustomerAndSuppliersByCityService = _CustomerAndSuppliersByCityService ?? new CustomerAndSuppliersByCityService(CustomerAndSuppliersByCityRepository);


				
		private ICustomerCustomerDemoRepository _CustomerCustomerDemoRepository;
        private ICustomerCustomerDemoRepository CustomerCustomerDemoRepository => _CustomerCustomerDemoRepository = _CustomerCustomerDemoRepository ?? new CustomerCustomerDemoRepository(_context);
        
		
        private ICustomerCustomerDemoService _CustomerCustomerDemoService;
        public ICustomerCustomerDemoService CustomerCustomerDemoServices => _CustomerCustomerDemoService = _CustomerCustomerDemoService ?? new CustomerCustomerDemoService(CustomerCustomerDemoRepository);


				
		private ICustomerDemographicRepository _CustomerDemographicRepository;
        private ICustomerDemographicRepository CustomerDemographicRepository => _CustomerDemographicRepository = _CustomerDemographicRepository ?? new CustomerDemographicRepository(_context);
        
		
        private ICustomerDemographicService _CustomerDemographicService;
        public ICustomerDemographicService CustomerDemographicServices => _CustomerDemographicService = _CustomerDemographicService ?? new CustomerDemographicService(CustomerDemographicRepository);


				
		private IEmployeeRepository _EmployeeRepository;
        private IEmployeeRepository EmployeeRepository => _EmployeeRepository = _EmployeeRepository ?? new EmployeeRepository(_context);
        
		
        private IEmployeeService _EmployeeService;
        public IEmployeeService EmployeeServices => _EmployeeService = _EmployeeService ?? new EmployeeService(EmployeeRepository);


				
		private IEmployeeTerritoryRepository _EmployeeTerritoryRepository;
        private IEmployeeTerritoryRepository EmployeeTerritoryRepository => _EmployeeTerritoryRepository = _EmployeeTerritoryRepository ?? new EmployeeTerritoryRepository(_context);
        
		
        private IEmployeeTerritoryService _EmployeeTerritoryService;
        public IEmployeeTerritoryService EmployeeTerritoryServices => _EmployeeTerritoryService = _EmployeeTerritoryService ?? new EmployeeTerritoryService(EmployeeTerritoryRepository);


				
		private IInvoiceRepository _InvoiceRepository;
        private IInvoiceRepository InvoiceRepository => _InvoiceRepository = _InvoiceRepository ?? new InvoiceRepository(_context);
        
		
        private IInvoiceService _InvoiceService;
        public IInvoiceService InvoiceServices => _InvoiceService = _InvoiceService ?? new InvoiceService(InvoiceRepository);


				
		private IOrderRepository _OrderRepository;
        private IOrderRepository OrderRepository => _OrderRepository = _OrderRepository ?? new OrderRepository(_context);
        
		
        private IOrderService _OrderService;
        public IOrderService OrderServices => _OrderService = _OrderService ?? new OrderService(OrderRepository);


				
		private IOrderDetailRepository _OrderDetailRepository;
        private IOrderDetailRepository OrderDetailRepository => _OrderDetailRepository = _OrderDetailRepository ?? new OrderDetailRepository(_context);
        
		
        private IOrderDetailService _OrderDetailService;
        public IOrderDetailService OrderDetailServices => _OrderDetailService = _OrderDetailService ?? new OrderDetailService(OrderDetailRepository);


				
		private IOrderDetailsExtendedRepository _OrderDetailsExtendedRepository;
        private IOrderDetailsExtendedRepository OrderDetailsExtendedRepository => _OrderDetailsExtendedRepository = _OrderDetailsExtendedRepository ?? new OrderDetailsExtendedRepository(_context);
        
		
        private IOrderDetailsExtendedService _OrderDetailsExtendedService;
        public IOrderDetailsExtendedService OrderDetailsExtendedServices => _OrderDetailsExtendedService = _OrderDetailsExtendedService ?? new OrderDetailsExtendedService(OrderDetailsExtendedRepository);


				
		private IOrdersQryRepository _OrdersQryRepository;
        private IOrdersQryRepository OrdersQryRepository => _OrdersQryRepository = _OrdersQryRepository ?? new OrdersQryRepository(_context);
        
		
        private IOrdersQryService _OrdersQryService;
        public IOrdersQryService OrdersQryServices => _OrdersQryService = _OrdersQryService ?? new OrdersQryService(OrdersQryRepository);


				
		private IOrderSubtotalRepository _OrderSubtotalRepository;
        private IOrderSubtotalRepository OrderSubtotalRepository => _OrderSubtotalRepository = _OrderSubtotalRepository ?? new OrderSubtotalRepository(_context);
        
		
        private IOrderSubtotalService _OrderSubtotalService;
        public IOrderSubtotalService OrderSubtotalServices => _OrderSubtotalService = _OrderSubtotalService ?? new OrderSubtotalService(OrderSubtotalRepository);


				
		private IProductRepository _ProductRepository;
        private IProductRepository ProductRepository => _ProductRepository = _ProductRepository ?? new ProductRepository(_context);
        
		
        private IProductService _ProductService;
        public IProductService ProductServices => _ProductService = _ProductService ?? new ProductService(ProductRepository);


				
		private IProductsAboveAveragePriceRepository _ProductsAboveAveragePriceRepository;
        private IProductsAboveAveragePriceRepository ProductsAboveAveragePriceRepository => _ProductsAboveAveragePriceRepository = _ProductsAboveAveragePriceRepository ?? new ProductsAboveAveragePriceRepository(_context);
        
		
        private IProductsAboveAveragePriceService _ProductsAboveAveragePriceService;
        public IProductsAboveAveragePriceService ProductsAboveAveragePriceServices => _ProductsAboveAveragePriceService = _ProductsAboveAveragePriceService ?? new ProductsAboveAveragePriceService(ProductsAboveAveragePriceRepository);


				
		private IProductSalesFor1997Repository _ProductSalesFor1997Repository;
        private IProductSalesFor1997Repository ProductSalesFor1997Repository => _ProductSalesFor1997Repository = _ProductSalesFor1997Repository ?? new ProductSalesFor1997Repository(_context);
        
		
        private IProductSalesFor1997Service _ProductSalesFor1997Service;
        public IProductSalesFor1997Service ProductSalesFor1997Services => _ProductSalesFor1997Service = _ProductSalesFor1997Service ?? new ProductSalesFor1997Service(ProductSalesFor1997Repository);


				
		private IProductsByCategoryRepository _ProductsByCategoryRepository;
        private IProductsByCategoryRepository ProductsByCategoryRepository => _ProductsByCategoryRepository = _ProductsByCategoryRepository ?? new ProductsByCategoryRepository(_context);
        
		
        private IProductsByCategoryService _ProductsByCategoryService;
        public IProductsByCategoryService ProductsByCategoryServices => _ProductsByCategoryService = _ProductsByCategoryService ?? new ProductsByCategoryService(ProductsByCategoryRepository);


				
		private IQuarterlyOrderRepository _QuarterlyOrderRepository;
        private IQuarterlyOrderRepository QuarterlyOrderRepository => _QuarterlyOrderRepository = _QuarterlyOrderRepository ?? new QuarterlyOrderRepository(_context);
        
		
        private IQuarterlyOrderService _QuarterlyOrderService;
        public IQuarterlyOrderService QuarterlyOrderServices => _QuarterlyOrderService = _QuarterlyOrderService ?? new QuarterlyOrderService(QuarterlyOrderRepository);


				
		private IRegionRepository _RegionRepository;
        private IRegionRepository RegionRepository => _RegionRepository = _RegionRepository ?? new RegionRepository(_context);
        
		
        private IRegionService _RegionService;
        public IRegionService RegionServices => _RegionService = _RegionService ?? new RegionService(RegionRepository);


				
		private ISalesByCategoryRepository _SalesByCategoryRepository;
        private ISalesByCategoryRepository SalesByCategoryRepository => _SalesByCategoryRepository = _SalesByCategoryRepository ?? new SalesByCategoryRepository(_context);
        
		
        private ISalesByCategoryService _SalesByCategoryService;
        public ISalesByCategoryService SalesByCategoryServices => _SalesByCategoryService = _SalesByCategoryService ?? new SalesByCategoryService(SalesByCategoryRepository);


				
		private ISalesTotalsByAmountRepository _SalesTotalsByAmountRepository;
        private ISalesTotalsByAmountRepository SalesTotalsByAmountRepository => _SalesTotalsByAmountRepository = _SalesTotalsByAmountRepository ?? new SalesTotalsByAmountRepository(_context);
        
		
        private ISalesTotalsByAmountService _SalesTotalsByAmountService;
        public ISalesTotalsByAmountService SalesTotalsByAmountServices => _SalesTotalsByAmountService = _SalesTotalsByAmountService ?? new SalesTotalsByAmountService(SalesTotalsByAmountRepository);


				
		private IShipperRepository _ShipperRepository;
        private IShipperRepository ShipperRepository => _ShipperRepository = _ShipperRepository ?? new ShipperRepository(_context);
        
		
        private IShipperService _ShipperService;
        public IShipperService ShipperServices => _ShipperService = _ShipperService ?? new ShipperService(ShipperRepository);


				
		private ISummaryOfSalesByQuarterRepository _SummaryOfSalesByQuarterRepository;
        private ISummaryOfSalesByQuarterRepository SummaryOfSalesByQuarterRepository => _SummaryOfSalesByQuarterRepository = _SummaryOfSalesByQuarterRepository ?? new SummaryOfSalesByQuarterRepository(_context);
        
		
        private ISummaryOfSalesByQuarterService _SummaryOfSalesByQuarterService;
        public ISummaryOfSalesByQuarterService SummaryOfSalesByQuarterServices => _SummaryOfSalesByQuarterService = _SummaryOfSalesByQuarterService ?? new SummaryOfSalesByQuarterService(SummaryOfSalesByQuarterRepository);


				
		private ISummaryOfSalesByYearRepository _SummaryOfSalesByYearRepository;
        private ISummaryOfSalesByYearRepository SummaryOfSalesByYearRepository => _SummaryOfSalesByYearRepository = _SummaryOfSalesByYearRepository ?? new SummaryOfSalesByYearRepository(_context);
        
		
        private ISummaryOfSalesByYearService _SummaryOfSalesByYearService;
        public ISummaryOfSalesByYearService SummaryOfSalesByYearServices => _SummaryOfSalesByYearService = _SummaryOfSalesByYearService ?? new SummaryOfSalesByYearService(SummaryOfSalesByYearRepository);


				
		private ISupplierRepository _SupplierRepository;
        private ISupplierRepository SupplierRepository => _SupplierRepository = _SupplierRepository ?? new SupplierRepository(_context);
        
		
        private ISupplierService _SupplierService;
        public ISupplierService SupplierServices => _SupplierService = _SupplierService ?? new SupplierService(SupplierRepository);


				
		private ITerritoryRepository _TerritoryRepository;
        private ITerritoryRepository TerritoryRepository => _TerritoryRepository = _TerritoryRepository ?? new TerritoryRepository(_context);
        
		
        private ITerritoryService _TerritoryService;
        public ITerritoryService TerritoryServices => _TerritoryService = _TerritoryService ?? new TerritoryService(TerritoryRepository);


				
	}
}
