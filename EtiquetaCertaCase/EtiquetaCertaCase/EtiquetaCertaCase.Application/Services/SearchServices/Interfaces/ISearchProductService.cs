using EtiquetaCertaCase.Core.Schema;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;

namespace EtiquetaCertaCase.Application.Services.SearchServices.Interfaces
{
    public interface ISearchProductService
    {
        Task<Result<ProductResponse>> SearchProduct(GetProductRequest request);
        Task<PaginatedResult<ProductResponse>> ListProduct();
    }
}