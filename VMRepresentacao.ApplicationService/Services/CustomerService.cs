using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;

namespace VMRepresentacao.ApplicationService.Services
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository repository) : base(repository) { }
    }
}
