using EtiquetaCertaCase.Application.Services.ManageServices.Interfaces;
using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;
using EtiquetaCertaCase.Core.Schema;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Application.Handler.ManageHandler
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductRequest, Result>
    {
        private readonly IManageProductService _manageProductService;

        public DeleteProductHandler(IManageProductService manageProductService)
        {
            _manageProductService = manageProductService;
        }

        public async Task<Result> Handle(DeleteProductRequest request, CancellationToken cancellationToken) =>
                            await _manageProductService.DeleteProduct(request);
    }
}
