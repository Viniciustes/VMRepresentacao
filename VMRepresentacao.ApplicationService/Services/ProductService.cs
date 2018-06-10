using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;

namespace VMRepresentacao.ApplicationService.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository) { }
    }
}
