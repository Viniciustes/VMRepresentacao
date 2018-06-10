using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;
using VMRepresentacao.Domain.Specifications;

namespace VMRepresentacao.ApplicationService.Services
{
    public class Service<Entity> : IService<Entity> where Entity : BaseEntity
    {
        private readonly IRepository<Entity> _repository;

        public Service(IRepository<Entity> repository)
        {
            _repository = repository;
        }

        public async Task Create(Entity entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task Delete(Entity entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task Edit(Entity entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<Entity>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            var specification = new GenericGetByIdSpecification<Entity>(id);
            return await _repository.GetBySpecificationAsync(specification);
        }
    }
}
