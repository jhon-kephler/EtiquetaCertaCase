using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request;
using EtiquetaCertaCase.Domain.Entities;
using EtiquetaCertaCase.Tests.Application.Services.ServicesBase;
using EtiquetaCertaCase.Tests.Mock.RepositoriesMock;
using EtiquetaCertaCase.Tests.Mock.SchemaMock.RequestMock;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Tests.Application.Services.ManageServices
{
    public class CreateProductTests : ManageProductServiceBaseTests
    {
        [Fact(DisplayName = "CreateProduct returns issuccess true and statuscode 201")]
        public async Task CreateProduct_Returns_IsSuccess_True_And_StatusCode_201()
        {
            _productRepositoryMock.Setup(s => s.AddAsync(new Product()));

            var manageProduct = await _manageProductService.CreateProduct(CreateProductRequestMock.CreateProduct());

            Assert.True(manageProduct.IsSuccess && manageProduct.StatusCode == 201);
        }

        [Fact(DisplayName = "CreateProduct returns issuccess true and statuscode 500")]
        public async Task CreateProduct_Returns_IsSuccess_True_And_StatusCode_500()
        {
            _productRepositoryMock.Setup(s => s.AddAsync(It.IsAny<Product>())).ThrowsAsync(new Exception());

            var manageProduct = await _manageProductService.CreateProduct(CreateProductRequestMock.CreateProduct());

            Assert.False(manageProduct.IsSuccess && manageProduct.StatusCode == 500);
        }

        [Fact(DisplayName = "CreateProduct returns issuccess true and statuscode 500 and validate text propertie")]
        public async Task CreateProduct_Returns_IsSuccess_True_And_StatusCode_500_And_ValidateTextPropertie()
        {
            _productRepositoryMock.Setup(s => s.AddAsync(It.IsAny<Product>())).ThrowsAsync(new Exception());

            var manageProduct = await _manageProductService.CreateProduct(CreateProductRequestMock.CreateProductLongText());

            Assert.False(manageProduct.IsSuccess && manageProduct.StatusCode == 500);
        }
    }
}
