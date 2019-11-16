using AutoMapper;
using OpenAPI.NBRB.Data.Entities;
using OpenAPI.NBRB.Domain.Contracts.ViewModels;

namespace OpenAPI.NBRB.Infrastructure.MappingProfiles
{
    public class BankMappingProfile : Profile
    {
        public BankMappingProfile()
        {
            MapBankToBankViewModel();
        }

        private void MapBankToBankViewModel()
        {
            CreateMap<Bank, BankViewModel>()
                .ForMember(dest => dest.BIC, c => c.MapFrom(src => src.BIC))
                .ForMember(dest => dest.IsActive, c => c.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.City, c => c.MapFrom(src => src.City))
                .ForMember(dest => dest.Address, c => c.MapFrom(src => src.Address))
                .ForMember(dest => dest.Phone, c => c.MapFrom(src => src.Phone))
                .ForAllOtherMembers(c => c.Ignore());
        }
    }
}
