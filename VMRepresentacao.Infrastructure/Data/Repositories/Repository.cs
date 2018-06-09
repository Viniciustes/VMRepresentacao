using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;
using VMRepresentacao.Domain.Interfaces.Specifications;
using VMRepresentacao.Infrastructure.Data.Contexts;

namespace VMRepresentacao.Infrastructure.Data.Repositories
{
    public class Repository<Entity> : IRepository<Entity> where Entity : BaseEntity
    {
        private readonly Context _context;

        public Repository(Context context)
        {
            _context = context;
        }

        public Entity Add(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public async Task<Entity> AddAsync(Entity entity)
        {
            await _context.Set<Entity>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public IEnumerable<Entity> AddRange(IEnumerable<Entity> entities)
        {
            _context.Set<Entity>().AddRange(entities);
            _context.SaveChanges();

            return entities;
        }

        public async Task<IEnumerable<Entity>> AddRangeAsync(IEnumerable<Entity> entities)
        {
            await _context.Set<Entity>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();

            return entities;
        }

        public void Delete(Entity entity)
        {
            _context.Set<Entity>().Remove(entity);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(Entity entity)
        {
            _context.Set<Entity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Entity>> GetAllActiveAsync()
        {
            return await _context.Set<Entity>().Where(x => x.Active == true).AsNoTracking().ToListAsync();
        }

        public Entity GetById(int id)
        {
            return _context.Set<Entity>().Find(id);
        }

        public Entity GetByIdAsNoTracking(int id)
        {
            return _context.Set<Entity>().AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<Entity> GetByIdAsNoTrackingAsync(int id)
        {
            return await _context.Set<Entity>().AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            return await _context.Set<Entity>().FindAsync(id);
        }

        public IEnumerable<Entity> ListAll()
        {
            return _context.Set<Entity>().AsEnumerable();
        }

        public async Task<IList<Entity>> ListAllAsync()
        {
            return await _context.Set<Entity>().ToListAsync();
        }

        public IEnumerable<Entity> ListAllAsNoTracking()
        {
            return _context.Set<Entity>().AsNoTracking().AsEnumerable();
        }

        public async Task<IList<Entity>> ListAllAsNoTrackingAsync()
        {
            return await _context.Set<Entity>().AsNoTracking().ToListAsync();
        }

        public void Update(Entity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Entity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Entity> GetBySpecificationAsync(ISpecification<Entity> specification)
        {
            return await _context.Set<Entity>().Where(specification.Criteria).FirstOrDefaultAsync();
        }

        public Entity GetBySpecification(ISpecification<Entity> specification)
        {
            return _context.Set<Entity>().Where(specification.Criteria).FirstOrDefault();
        }
    }
}
