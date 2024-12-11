using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;
using EtiquetaCertaCase.Core.Schema;

namespace EtiquetaCertaCase.Application.Services.ManageServices.Interfaces
{
    public interface IManageProductService
    {
        Task<Result> CreateProduct(CreateProductRequest request);
        Task<Result> UpdateProduct(UpdateProductRequest request);
        Task<Result> DeleteProduct(DeleteProductRequest request);
    }
}