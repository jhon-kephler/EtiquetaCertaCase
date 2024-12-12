using EtiquetaCertaCase.Domain.Entities;
using EtiquetaCertaCase.Tests.Application.Services.ServicesBase;
using EtiquetaCertaCase.Tests.Mock.RepositoriesMock;
using EtiquetaCertaCase.Tests.Mock.SchemaMock.RequestMock;

namespace EtiquetaCertaCase.Tests.Application.Services.ManageServices
{
    public class UpdateProductTests : ManageProductServiceBaseTests
    {
        [Fact(DisplayName = "UpdateProduct returns issuccess true and statuscode 200")]
        public async Task UpdateProduct_Returns_IsSuccess_True_And_StatusCode_200()
        {
            _productRepositoryMock.Setup(s => s.GetById(1)).Returns(ProductRepositoryMock.GetProduct());
            _productRepositoryMock.Setup(s => s.Update(1, new Product()));

            var manageProduct = await _manageProductService.UpdateProduct(UpdateProductRequestMock.UpdateProduct());

            Assert.True(manageProduct.IsSuccess && manageProduct.StatusCode == 200);
        }

        [Fact(DisplayName = "UpdateProduct returns issuccess true and statuscode 500")]
        public async Task UpdateProduct_Returns_IsSuccess_True_And_StatusCode_500()
        {
            _productRepositoryMock.Setup(s => s.GetById(1)).Returns(ProductRepositoryMock.GetProduct());
            _productRepositoryMock.Setup(s => s.Update(1, new Product())).Throws(new Exception());

            var manageProduct = await _manageProductService.UpdateProduct(UpdateProductRequestMock.UpdateProduct());

            Assert.False(manageProduct.IsSuccess && manageProduct.StatusCode == 500);
        }

        [Fact(DisplayName = "UpdateProduct returns issuccess true and statuscode 500 and validate text propertie")]
        public async Task UpdateProduct_Returns_IsSuccess_True_And_StatusCode_500_And_ValidateTextPropertie()
        {
            _productRepositoryMock.Setup(s => s.GetById(1)).Returns(ProductRepositoryMock.GetProduct());
            _productRepositoryMock.Setup(s => s.Update(1, new Product()));

            var manageProduct = await _manageProductService.UpdateProduct(UpdateProductRequestMock.UpdateProductLongText());

            Assert.False(manageProduct.IsSuccess && manageProduct.StatusCode == 500);
        }
    }
}
