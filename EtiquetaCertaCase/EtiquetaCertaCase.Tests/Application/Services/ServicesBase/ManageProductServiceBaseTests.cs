using AutoMapper;
using EtiquetaCertaCase.Application.Services.ManageServices;
using EtiquetaCertaCase.Core.Mapper;
using EtiquetaCertaCase.Domain.Repositories;
using Moq;

namespace EtiquetaCertaCase.Tests.Application.Services.ServicesBase
{
    public class ManageProductServiceBaseTests
    {
        protected readonly IMapper _mapper;
        protected readonly Mock<IProductRepository> _productRepositoryMock;
        protected readonly ManageProductService _manageProductService;

        public ManageProductServiceBaseTests()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductProfile>();
            });
            _mapper = mapperConfig.CreateMapper();

            _productRepositoryMock = new Mock<IProductRepository>();

            _manageProductService = new ManageProductService(_mapper, _productRepositoryMock.Object);
        }
    }
}
