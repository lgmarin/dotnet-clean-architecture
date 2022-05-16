using AutoMapper;
using mvcCleanArch.Application.ViewModels;
using mvcCleanArch.Domain.Entities;

namespace mvcCleanArch.Application.Mappings;

public class DomainToViewModelMappingProfile: Profile
{
    public DomainToViewModelMappingProfile()
    {
        CreateMap<Product, ProductViewModel>();
    }
}