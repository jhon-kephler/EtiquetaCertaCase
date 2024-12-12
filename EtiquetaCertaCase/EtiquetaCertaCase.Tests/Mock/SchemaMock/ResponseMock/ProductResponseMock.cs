using EtiquetaCertaCase.Core.Schema;
using EtiquetaCertaCase.Core.Schema.ProductSchema.SearchSchema.Response;
using EtiquetaCertaCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Tests.Mock.SchemaMock.ResponseMock
{
    public class ProductResponseMock
    {
        public static ProductResponse GetProduct()
        {
            var product = new ProductResponse
            {
                Id = 1,
                Name = "Agua",
                Category = "Bebiba",
                Price = 5,
            };
            return product;
        }

        public static PaginatedResult<ProductResponse> ListProduct()
        {
            var listProduct = new PaginatedResult<ProductResponse>
            {
                Data = new List<ProductResponse>
                {
                    new ProductResponse
                    {
                        Id = 1,
                        Name = "Agua",
                        Category = "Bebiba",
                        Price = 5,
                    },
                    new ProductResponse
                    {
                        Id = 2,
                        Name = "Coca-Cola",
                        Category = "Bebiba",
                        Price = 10,
                    },
                    new ProductResponse
                    {
                        Id = 3,
                        Name = "Suco",
                        Category = "Bebiba",
                        Price = 11,
                    },
                    new ProductResponse
                    {
                        Id = 4,
                        Name = "Pepsi",
                        Category = "Bebiba",
                        Price = 5,
                    },
                }
            };
            
            return listProduct;
        }
    }
}
