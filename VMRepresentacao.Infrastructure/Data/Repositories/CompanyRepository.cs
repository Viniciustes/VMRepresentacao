using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;
using VMRepresentacao.Infrastructure.Data.Contexts;

namespace VMRepresentacao.Infrastructure.Data.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(Context context) : base(context)
        {
        }
    }
}
