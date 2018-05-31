using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllActive();
    }
}
