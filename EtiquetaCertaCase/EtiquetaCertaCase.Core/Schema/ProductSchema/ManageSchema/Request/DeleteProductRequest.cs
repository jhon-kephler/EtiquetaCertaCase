using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request
{
    public class DeleteProductRequest : IRequest<Result>
    {
        public DeleteProductRequest() { }

        public DeleteProductRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
