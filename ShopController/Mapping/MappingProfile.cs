using AutoMapper;
using Queries.Core.Domain;
using ShopController.Resources;

namespace ShopController.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ItemResources, Item>();
    }
}
