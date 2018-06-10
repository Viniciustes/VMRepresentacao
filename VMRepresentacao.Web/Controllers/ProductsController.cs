using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.ApplicationService.Interfaces;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Web.ViewModels;

namespace VMRepresentacao.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductsController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllActiveAsync();
            var productsViewModel = _mapper.Map<IEnumerable<ProductViewModel>>(products);

            return View(productsViewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            return await ReturnViewModelProductsById(id);
        }

        public IActionResult Create()
        {
            ViewData["Action"] = "Create";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel productViewModel)
        {
            ViewData["Action"] = "Create";

            if (!ModelState.IsValid) return View();

            try
            {
                var product = _mapper.Map<Product>(productViewModel);
                await _productService.Create(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewData["Action"] = "Edit";

            return await ReturnViewModelProductsById(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductViewModel productViewModel)
        {
            ViewData["Action"] = "Edit";

            if (!ModelState.IsValid) return View(productViewModel);

            try
            {
                var product = _mapper.Map<Product>(productViewModel);
                await _productService.Edit(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            return await ReturnViewModelProductsById(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, ProductViewModel productViewModel)
        {
            try
            {
                var product = _mapper.Map<Product>(productViewModel);
                await _productService.Delete(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private async Task<IActionResult> ReturnViewModelProductsById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var productViewModel = _mapper.Map<ProductViewModel>(product);

            return View(productViewModel);
        }
    }
}