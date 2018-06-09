using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Web.ViewModels;

namespace VMRepresentacao.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new List<CustomersViewModel>();
            var customers = await _customerService.GetAllActiveAsync();

            foreach (var customer in customers)
            {
                viewModel.Add(new CustomersViewModel
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    CNPJ = customer.CNPJ.Number,
                    CPF = customer.CPF.Number,
                    Email = customer.Email.Address
                });
            }

            return View(viewModel);
        }
    }
}