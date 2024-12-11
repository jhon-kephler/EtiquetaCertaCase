using EtiquetaCertaCase.Application.Services.SearchServices.Interfaces;
using EtiquetaCertaCase.Core.Schema;
using MediatR;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;

namespace EtiquetaCertaCase.Application.Handler.SearchHandler
{
    public class ListProductHandler : IRequestHandler<ListProductRequest, PaginatedResult<ProductResponse>>
    {
        private readonly ISearchProductService _searchProductService;

        public ListProductHandler(ISearchProductService searchProductService)
        {
            _searchProductService = searchProductService;
        }

        public async Task<PaginatedResult<ProductResponse>> Handle(ListProductRequest request, CancellationToken cancellationToken) =>
                            await _searchProductService.ListProduct();
    }
}
