using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request;
using EtiquetaCertaCase.Domain.Entities;
using EtiquetaCertaCase.Tests.Application.Services.ServicesBase;
using EtiquetaCertaCase.Tests.Mock.RepositoriesMock;
using EtiquetaCertaCase.Tests.Mock.SchemaMock.ResponseMock;

namespace EtiquetaCertaCase.Tests.Application.Services.SearchServices
{
    public class SearchProductTests : SearchProductServiceBaseTests
    {
        [Fact(DisplayName = "SearchProduct returns issuccess true and data different null")]
        public async Task SearchProduct_Returns_IsSuccess_True_And_Data_Different_Null()
        {
            _productRepositoryMock.Setup(s => s.GetById(1)).Returns(ProductRepositoryMock.GetProduct());

            var productRequest = new GetProductRequest(1);
            var searchProduct = await _searchProductService.SearchProduct(productRequest);

            Assert.True(searchProduct.IsSuccess && searchProduct.Data != null);
        }

        [Fact(DisplayName = "SearchProduct returns issuccess true and data null")]
        public async Task SearchProduct_Returns_IsSuccess_True_And_Data_Null()
        {
            _productRepositoryMock.Setup(s => s.GetById(0)).Returns(new Product());

            var productRequest = new GetProductRequest(0);
            var searchProduct = await _searchProductService.SearchProduct(productRequest);

            Assert.False(!searchProduct.IsSuccess && searchProduct.Data != null);
        }

        [Fact(DisplayName = "SearchProduct returns issuccess true and data different null promotional month november")]
        public async Task SearchProduct_Returns_IsSuccess_True_And_Data_Different_Null_Promotinal_Month_November()
        {
            _productRepositoryMock.Setup(s => s.GetById(1)).Returns(ProductRepositoryMock.GetProduct());

            var productRequest = new GetProductRequest(1);
            var searchProduct = await _searchProductService.SearchProduct(productRequest);
            searchProduct.Data = await _searchProductService.ValidatePromotional(ProductResponseMock.GetProduct(), 11);

            Assert.True(searchProduct.IsSuccess && searchProduct.Data != null && searchProduct.Data.Price != ProductRepositoryMock.GetProduct().Price);
        }

        [Fact(DisplayName = "SearchProduct returns issuccess true and data different null promotional month not november")]
        public async Task SearchProduct_Returns_IsSuccess_True_And_Data_Different_Null_Promotinal_Month_Not_November()
        {
            _productRepositoryMock.Setup(s => s.GetById(1)).Returns(ProductRepositoryMock.GetProduct());

            var productRequest = new GetProductRequest(1);
            var searchProduct = await _searchProductService.SearchProduct(productRequest);
            searchProduct.Data = await _searchProductService.ValidatePromotional(ProductResponseMock.GetProduct(), 12);

            Assert.True(searchProduct.IsSuccess && searchProduct.Data != null && searchProduct.Data.Price == ProductRepositoryMock.GetProduct().Price);
        }
    }
}
