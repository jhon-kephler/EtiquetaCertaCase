using EtiquetaCertaCase.Domain.Entities;
using EtiquetaCertaCase.Tests.Application.Services.ServicesBase;
using EtiquetaCertaCase.Tests.Mock.SchemaMock.RequestMock;

namespace EtiquetaCertaCase.Tests.Application.Services.ManageServices
{
    public class DeleteProductTests : ManageProductServiceBaseTests
    {
        [Fact(DisplayName = "DeleteProduct returns issuccess true and statuscode 200")]
        public async Task DeleteProduct_Returns_IsSuccess_True_And_StatusCode_200()
        {
            _productRepositoryMock.Setup(s => s.Delete(1));

            var manageProduct = await _manageProductService.DeleteProduct(DeleteProductRequestMock.DeleteProduct());

            Assert.True(manageProduct.IsSuccess && manageProduct.StatusCode == 200);
        }

        [Fact(DisplayName = "DeleteProduct returns issuccess true and statuscode 500")]
        public async Task DeleteProduct_Returns_IsSuccess_True_And_StatusCode_500()
        {
            _productRepositoryMock.Setup(s => s.Delete(0)).Throws(new Exception());

            var manageProduct = await _manageProductService.DeleteProduct(DeleteProductRequestMock.DeleteProduct());

            Assert.False(!manageProduct.IsSuccess && manageProduct.StatusCode == 500);
        }
    }
}
