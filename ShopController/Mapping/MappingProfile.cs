using AutoMapper;
using Queries.Core.Domain;
using ShopController.Resources;

namespace ShopController.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Resources to domain
        CreateMap<ItemResources, Item>();

        // domain to resources
        CreateMap<Item, ItemResources>();
    }
}
