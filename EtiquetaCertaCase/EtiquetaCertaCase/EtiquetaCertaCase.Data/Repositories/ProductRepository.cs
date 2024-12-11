using EtiquetaCertaCase.Domain.Entities;
using EtiquetaCertaCase.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EtiquetaCertaCase.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
