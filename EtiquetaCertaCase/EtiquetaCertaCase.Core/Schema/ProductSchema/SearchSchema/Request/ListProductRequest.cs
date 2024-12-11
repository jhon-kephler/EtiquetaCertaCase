using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Request
{
    public class ListProductRequest : IRequest<PaginatedResult<ProductResponse>>
    {
    }
}
