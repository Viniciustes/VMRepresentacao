using AutoMapper;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Web.ViewModels;

namespace VMRepresentacao.Web.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<Customer, CustomerViewModel>();
            CreateMap<CustomerViewModel, Customer>();
        }
    }
}
