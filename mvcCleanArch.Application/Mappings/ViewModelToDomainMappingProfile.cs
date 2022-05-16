using AutoMapper;
using mvcCleanArch.Application.ViewModels;
using mvcCleanArch.Domain.Entities;

namespace mvcCleanArch.Application.Mappings;

public class ViewModeToDomainMappingProfile: Profile
{
    public ViewModeToDomainMappingProfile()
    {
        CreateMap<ProductViewModel, Product>();
    }
}