using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.ApplicationService.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllActive();
    }
}
