using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;
using VMRepresentacao.Domain.Specifications;
using VMRepresentacao.Domain.Specifications.ProductsSpecifications;

namespace VMRepresentacao.ApplicationService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllActiveAsync()
        {
            return await _productRepository.GetAllActiveAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var specification = new GenericGetByIdSpecification<Product>(id);
            return await _productRepository.GetBySpecificationAsync(specification);
        }

        public async Task<Product> GetByNameAsync(string name)
        {
            var specification = new ProductGetByNameSpecification(name);
            return await _productRepository.GetBySpecificationAsync(specification);
        }
    }
}
