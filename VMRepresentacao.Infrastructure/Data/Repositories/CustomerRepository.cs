using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;
using VMRepresentacao.Infrastructure.Data.Contexts;

namespace VMRepresentacao.Infrastructure.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(Context context) : base(context) { }
    }
}
