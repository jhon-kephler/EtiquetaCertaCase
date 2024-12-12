using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Tests.Mock.SchemaMock.RequestMock
{
    public class UpdateProductRequestMock
    {
        public static UpdateProductRequest UpdateProduct()
        {
            var product = new UpdateProductRequest
            {
                Id = 1,
                Name = "Agua de Coco",
                Category = "Bebiba",
                Price = 5,
            };
            return product;
        }

        public static UpdateProductRequest UpdateProductLongText()
        {
            var product = new UpdateProductRequest
            {
                Id = 1,
                Name = "Agua de Coco Agua de Coco Agua de Coco Agua de Coco Agua de Coco Agua de Coco Agua de Coco Agua de Coco Agua de Coco Agua de Coco Agua de Coco Agua de Coco",
                Category = "Bebiba",
                Price = 5,
            };
            return product;
        }
    }
}
