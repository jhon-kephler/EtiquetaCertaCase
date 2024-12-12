using EtiquetaCertaCase.Core.Schema.ProductSchema.ManageSchema.Request;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;
using EtiquetaCertaCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Tests.Mock.SchemaMock.RequestMock
{
    public static class CreateProductRequestMock
    {
        public static CreateProductRequest CreateProduct()
        {
            var product = new CreateProductRequest
            {
                Name = "Agua",
                Category = "Bebiba",
                Price = 5,
            };
            return product;
        }

        public static CreateProductRequest CreateProductLongText()
        {
            var product = new CreateProductRequest
            {
                Name = "Agua",
                Category = "Bebiba Bebiba  Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba Bebiba",
                Price = 5,
            };
            return product;
        }
    }
}
