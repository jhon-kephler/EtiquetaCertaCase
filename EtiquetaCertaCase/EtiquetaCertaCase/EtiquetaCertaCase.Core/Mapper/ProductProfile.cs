using AutoMapper;
using EtiquetaCertaCase.Domain.Entities;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;
using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;

namespace EtiquetaCertaCase.Core.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponse>()
            .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
            .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
            .ForMember(dest => dest.Category, src => src.MapFrom(x => x.Category))
            .ForMember(dest => dest.Price, src => src.MapFrom(x => x.Price));

            CreateMap<CreateProductRequest, Product>()
            .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
            .ForMember(dest => dest.Category, src => src.MapFrom(x => x.Category))
            .ForMember(dest => dest.Price, src => src.MapFrom(x => x.Price));

            CreateMap<UpdateProductRequest, Product>()
            .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
            .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
            .ForMember(dest => dest.Category, src => src.MapFrom(x => x.Category))
            .ForMember(dest => dest.Price, src => src.MapFrom(x => x.Price));
        }
    }
}
