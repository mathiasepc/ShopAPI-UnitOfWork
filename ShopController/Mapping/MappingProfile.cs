using AutoMapper;
using Queries.Core.Domain;
using ShopController.Resources;

namespace ShopController.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // domain to resources
        CreateMap<Item, ItemResource>();
        CreateMap<Model, KeyValuePairResource>();
        CreateMap<Make, MakeResource>();

        // Resources to domain
        CreateMap<ItemResource, Item>();
    }
}
