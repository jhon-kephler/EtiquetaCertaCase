using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request;
using EtiquetaCertaCase.Domain.Entities;
using EtiquetaCertaCase.Tests.Application.Services.ServicesBase;
using EtiquetaCertaCase.Tests.Mock.RepositoriesMock;
using EtiquetaCertaCase.Tests.Mock.SchemaMock.ResponseMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Tests.Application.Services.SearchServices
{
    public class ListProductTests : SearchProductServiceBaseTests
    {
        [Fact(DisplayName = "ListProduct returns issuccess true and data different null")]
        public async Task ListProduct_Returns_IsSuccess_True_And_Data_Different_Null()
        {
            _productRepositoryMock.Setup(s => s.GetAll()).Returns(ProductRepositoryMock.ListProduct());

            var productRequest = new ListProductRequest();
            var listProduct = await _searchProductService.ListProduct();

            Assert.True(listProduct.IsSuccess && listProduct.Data != null);
        }

        [Fact(DisplayName = "ListProduct returns issuccess true and data null")]
        public async Task ListProduct_Returns_IsSuccess_True_And_Data_Null()
        {
            _productRepositoryMock.Setup(s => s.GetAll()).Returns(new List<Product>());

            var productRequest = new ListProductRequest();
            var listProduct = await _searchProductService.ListProduct();

            Assert.False(!listProduct.IsSuccess && listProduct.Data != null);
        }

        [Fact(DisplayName = "ListProduct returns issuccess true and data different null promotional month november")]
        public async Task ListProduct_Returns_IsSuccess_True_And_Data_Different_Null_Promotinal_Month_November()
        {
            _productRepositoryMock.Setup(s => s.GetAll()).Returns(ProductRepositoryMock.ListProduct());

            var productRequest = new ListProductRequest();
            var listProduct = await _searchProductService.ListProduct();
            await _searchProductService.ValidatePromotional(ProductResponseMock.GetProduct(), 11);

            Assert.True(listProduct.IsSuccess && listProduct.Data != null && listProduct.Data.FirstOrDefault().Price == ProductRepositoryMock.ListProduct().FirstOrDefault().Price);
        }

        [Fact(DisplayName = "ListProduct returns issuccess true and data different null promotional month not november")]
        public async Task ListProduct_Returns_IsSuccess_True_And_Data_Different_Null_Promotinal_Month_Not_November()
        {
            _productRepositoryMock.Setup(s => s.GetAll()).Returns(ProductRepositoryMock.ListProduct());

            var productRequest = new ListProductRequest();
            var listProduct = await _searchProductService.ListProduct();
            await _searchProductService.ValidatePromotional(ProductResponseMock.GetProduct(), 12);

            Assert.True(listProduct.IsSuccess && listProduct.Data != null && listProduct.Data.FirstOrDefault().Price == ProductRepositoryMock.ListProduct().FirstOrDefault().Price);
        }
    }
}
