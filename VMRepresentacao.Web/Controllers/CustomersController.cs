using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Web.ViewModels.Entities;

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
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        public async Task<IActionResult> Edit(int idViewModel)
        {
            ViewData["Action"] = "Edit";

            return await ReturnViewModelCustomerById(idViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Edit(CustomerViewModel customerViewModel)
        {
            ViewData["Action"] = "Edit";

            if (!ModelState.IsValid) return View();

            try
            {
                var customer = _mapper.Map<Customer>(customerViewModel);

                await _customerService.Edit(customer);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var erro = ex;
                return View();
            }
        }

        public async Task<IActionResult> Delete(int idViewModel)
        {
            return await ReturnViewModelCustomerById(idViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Delete(CustomerViewModel customerViewModel)
        {
            try
            {
                var customer = _mapper.Map<Customer>(customerViewModel);

                await _customerService.Delete(customer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Details(int idViewModel)
        {
            return await ReturnViewModelCustomerById(idViewModel);
        }

        private async Task<IActionResult> ReturnViewModelCustomerById(int idViewModel)
        {
            var customer = await _customerService.GetByIdAsync(idViewModel);
            var customerViewModel = _mapper.Map<CustomerViewModel>(customer);

            return View(customerViewModel);
        }
    }
}