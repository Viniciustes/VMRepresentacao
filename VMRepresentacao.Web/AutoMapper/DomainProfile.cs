using AutoMapper;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Web.ViewModels.Entities;

namespace VMRepresentacao.Web.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(x => x.IdViewModel, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.NameViewModel, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.PriceViewModel, y => y.MapFrom(z => z.Price))
                .ForMember(x => x.DescriptionViewModel, y => y.MapFrom(z => z.Description))
                .ReverseMap();

            CreateMap<Customer, CustomerViewModel>()
                .ForMember(x => x.IdViewModel, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.NameViewModel, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.EmailViewModel, y => y.MapFrom(z => z.Email.Address))
                .ForMember(x => x.CPFViewModel, y => y.MapFrom(z => z.CPF.Number))
                .ForMember(x => x.CNPJViewModel, y => y.MapFrom(z => z.CNPJ.Number))

                .ForPath(x => x.AddressViewModel.IdViewModel, y => y.MapFrom(z => z.Address.Id))
                .ForPath(x => x.AddressViewModel.SuperscriptionViewModel, y => y.MapFrom(z => z.Address.Superscription))
                .ForPath(x => x.AddressViewModel.ZipCodeViewModel, y => y.MapFrom(z => z.Address.ZipCode.Number))
                .ForPath(x => x.AddressViewModel.StateViewModel, y => y.MapFrom(z => z.Address.State))
                .ForPath(x => x.AddressViewModel.CityViewModel, y => y.MapFrom(z => z.Address.City))
                .ForPath(x => x.AddressViewModel.NumberViewModel, y => y.MapFrom(z => z.Address.Number))
                .ForPath(x => x.AddressViewModel.DistrictViewModel, y => y.MapFrom(z => z.Address.District))
                .ForPath(x => x.AddressViewModel.TypeOfAddressViewModel, y => y.MapFrom(z => z.Address.TypeOfAddress))
                .ForPath(x => x.AddressViewModel.ReferenceViewModel, y => y.MapFrom(z => z.Address.Reference))
                .ReverseMap();
        }
    }
}
