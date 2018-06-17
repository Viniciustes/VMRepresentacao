using System.Collections.Generic;
using System.Threading.Tasks;

namespace VMRepresentacao.ApplicationService.Interfaces
{
    public interface IService<Entity> where Entity : class
    {
        Task Edit(Entity entity);
        Task Create(Entity entity);
        Task Delete(Entity entity);
        Task<Entity> GetByIdAsync(int id);
        Task<IEnumerable<Entity>> GetAllActiveAsync();
    }
}
