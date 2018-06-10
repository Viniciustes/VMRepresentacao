using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.ApplicationService.Interfaces
{
    public interface IService<Entity> where Entity : BaseEntity
    {
        Task Edit(Entity entity);
        Task Create(Entity entity);
        Task Delete(Entity entity);
        Task<Entity> GetByIdAsync(int id);
        Task<IEnumerable<Entity>> GetAllActiveAsync();
    }
}
