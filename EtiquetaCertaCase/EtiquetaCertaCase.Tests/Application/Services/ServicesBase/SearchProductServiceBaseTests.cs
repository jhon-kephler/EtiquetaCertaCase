using AutoMapper;
using EtiquetaCertaCase.Application.Services.SearchServices;
using EtiquetaCertaCase.Core.Mapper;
using EtiquetaCertaCase.Domain.Repositories;
using Moq;

namespace EtiquetaCertaCase.Tests.Application.Services.ServicesBase
{
    public class SearchProductServiceBaseTests
    {
        protected readonly IMapper _mapper;
        protected readonly Mock<IProductRepository> _productRepositoryMock;
        protected readonly SearchProductService _searchProductService;

        public SearchProductServiceBaseTests()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductProfile>();
            });
            _mapper = mapperConfig.CreateMapper();

            _productRepositoryMock = new Mock<IProductRepository>();

            _searchProductService = new SearchProductService(_mapper, _productRepositoryMock.Object);
        }
    }
}
