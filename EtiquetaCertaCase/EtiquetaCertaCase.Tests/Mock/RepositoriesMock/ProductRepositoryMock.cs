using EtiquetaCertaCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Tests.Mock.RepositoriesMock
{
    public static class ProductRepositoryMock
    {
        public static Product GetProduct()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Agua",
                Category = "Bebiba",
                Price = 5,
            };
            return product;
        }

        public static List<Product> ListProduct()
        {
            var listProduct = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Agua",
                    Category = "Bebiba",
                    Price = 5,
                },
                new Product
                {
                    Id = 2,
                    Name = "Coca-Cola",
                    Category = "Bebiba",
                    Price = 10,
                },
                new Product
                {
                    Id = 3,
                    Name = "Suco",
                    Category = "Bebiba",
                    Price = 11,
                },
                new Product
                {
                    Id = 4,
                    Name = "Pepsi",
                    Category = "Bebiba",
                    Price = 5,
                },
            };
            return listProduct;
        }
    }
}
