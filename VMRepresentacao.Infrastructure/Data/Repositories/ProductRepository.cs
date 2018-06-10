using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;
using VMRepresentacao.Infrastructure.Data.Contexts;

namespace VMRepresentacao.Infrastructure.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(Context context) : base(context) { }
    }
}
