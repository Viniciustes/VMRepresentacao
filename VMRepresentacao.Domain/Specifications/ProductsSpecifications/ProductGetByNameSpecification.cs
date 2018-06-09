using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Domain.Specifications.ProductsSpecifications
{
    public class ProductGetByNameSpecification : BaseSpecification<Product>
    {
        public ProductGetByNameSpecification(string name) : base(x => x.Name == name) { }
    }
}
