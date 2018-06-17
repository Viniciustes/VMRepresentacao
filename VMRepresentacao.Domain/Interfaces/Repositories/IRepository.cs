using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.Domain.Interfaces.Specifications;

namespace VMRepresentacao.Domain.Interfaces.Repositories
{
    public interface IRepository<Entity> where Entity : class
    {
        Entity GetById(int id);
        Entity GetByIdAsNoTracking(int id);
        Entity GetBySpecification(ISpecification<Entity> specification);
        IEnumerable<Entity> ListAll();
        IEnumerable<Entity> ListAllAsNoTracking();
        void Update(Entity entity);
        void Delete(Entity entity);
        Entity Add(Entity entity);
        IEnumerable<Entity> AddRange(IEnumerable<Entity> entities);

        //ASYNCHRONOUS
        Task<IEnumerable<Entity>> GetAllActiveAsync();
        Task<Entity> GetByIdAsync(int id);
        Task<Entity> GetByIdAsNoTrackingAsync(int id);
        Task<Entity> GetBySpecificationAsync(ISpecification<Entity> specification);
        Task<IList<Entity>> ListAllAsync();
        Task<IList<Entity>> ListAllAsNoTrackingAsync();
        Task UpdateAsync(Entity entity);
        Task DeleteAsync(Entity entity);
        Task<Entity> AddAsync(Entity entity);
        Task<IEnumerable<Entity>> AddRangeAsync(IEnumerable<Entity> entities);
    }
}
