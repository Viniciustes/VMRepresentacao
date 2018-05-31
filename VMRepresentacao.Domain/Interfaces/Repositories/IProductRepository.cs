using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllActive();
    }
}
