using EtiquetaCertaCase.Application.Services.ManageServices.Interfaces;
using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;
using EtiquetaCertaCase.Core.Schema;
using MediatR;

namespace EtiquetaCertaCase.Application.Handler.ManageHandler
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductRequest, Result>
    {
        private readonly IManageProductService _manageProductService;

        public UpdateProductHandler(IManageProductService manageProductService)
        {
            _manageProductService = manageProductService;
        }

        public async Task<Result> Handle(UpdateProductRequest request, CancellationToken cancellationToken) =>
                            await _manageProductService.UpdateProduct(request);
    }
}