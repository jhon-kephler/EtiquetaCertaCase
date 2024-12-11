using EtiquetaCertaCase.Application.Services.SearchServices.Interfaces;
using EtiquetaCertaCase.Core.Schema;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;

namespace EtiquetaCertaCase.Application.Handler.SearchHandler
{
    public class SearchProductHandler : IRequestHandler<GetProductRequest, Result<ProductResponse>>
    {
        private readonly ISearchProductService _searchProductService;

        public SearchProductHandler(ISearchProductService searchProductService)
        {
            _searchProductService = searchProductService;
        }

        public async Task<Result<ProductResponse>> Handle(GetProductRequest request, CancellationToken cancellationToken) =>
                            await _searchProductService.SearchProduct(request);
    }
}
