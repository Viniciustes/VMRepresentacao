using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Interfaces.Repositories;

namespace VMRepresentacao.ApplicationService.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> GetAllActiveAsync()
        {
            return await _customerRepository.GetAllActiveAsync();
        }
    }
}
