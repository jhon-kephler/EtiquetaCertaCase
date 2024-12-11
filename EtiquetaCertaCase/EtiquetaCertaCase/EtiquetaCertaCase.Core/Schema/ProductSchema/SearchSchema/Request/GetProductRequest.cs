using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;
using MediatR;

namespace EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request
{
    public class GetProductRequest : IRequest<Result<ProductResponse>>
    {
        public int Id { get; set; }
    }
}
