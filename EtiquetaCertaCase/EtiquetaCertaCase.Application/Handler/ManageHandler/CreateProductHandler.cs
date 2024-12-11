using EtiquetaCertaCase.Core.Schema;
using MediatR;
using EtiquetaCertaCase.Application.Services.ManageServices.Interfaces;
using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;

namespace EtiquetaCertaCase.Application.Handler.ManageHandler
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest, Result>
    {
        private readonly IManageProductService _manageProductService;

        public CreateProductHandler(IManageProductService manageProductService)
        {
            _manageProductService = manageProductService;
        }

        public async Task<Result> Handle(CreateProductRequest request, CancellationToken cancellationToken) =>
                            await _manageProductService.CreateProduct(request);
    }
}
