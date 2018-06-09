using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Domain.Specifications
{
    public class GenericGetByIdSpecification<Entity> : BaseSpecification<Entity> where Entity : BaseEntity
    {
        public GenericGetByIdSpecification(int id) : base(x => x.Id == id) { }
    }
}
