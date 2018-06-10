using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Web.ViewModels;

namespace VMRepresentacao.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public CustomersController(IMapper mapper, ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _customerService.GetAllActiveAsync();
            var customersViewModel = _mapper.Map<IEnumerable<CustomerViewModel>>(customers);

            return View(customersViewModel);
        }

        public IActionResult Create()
        {
            ViewData["Action"] = "Create";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerViewModel customerViewModel)
        {
            ViewData["Action"] = "Create";

            if (!ModelState.IsValid) return View();

            try
            {
                var customer = _mapper.Map<Customer>(customerViewModel);
                await _customerService.Create(customer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}