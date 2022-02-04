

// 
// This is an auto generated file. 
// Do not make manual change
//  
using AutoMapper;
using GenericRepository.API.DTO;
using GenericRepository.Core.Models;

namespace GenericRepository.API.Mapping
{
	public partial class MappingProfile : Profile
    {
		public MappingProfile()
		{
						
			CreateMap<Category, CategoryDTO>();
			CreateMap<CategoryDTO, Category>();
			
						
			CreateMap<Customer, CustomerDTO>();
			CreateMap<CustomerDTO, Customer>();
			
			
		}
	}
}
