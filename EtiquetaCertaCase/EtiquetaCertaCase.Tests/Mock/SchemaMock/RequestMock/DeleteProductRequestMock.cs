using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Tests.Mock.SchemaMock.RequestMock
{
    public static class DeleteProductRequestMock
    {
        public static DeleteProductRequest DeleteProduct() => new DeleteProductRequest(1);
    }
}
