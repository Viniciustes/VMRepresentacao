using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VMRepresentacao.ApplicationService.Interfaces;
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

        public async Task<ActionResult> Index()
        {
            var listProducts = await _productService.GetAllActiveAsync();
            var viewModel = _mapper.Map<IEnumerable<ProductsViewModel>>(listProducts);

            return View(viewModel);
        }

        // GET: Teste/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teste/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teste/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductsViewModel productsViewModel)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Teste/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teste/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductsViewModel productsViewModel)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Teste/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teste/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductsViewModel productsViewModel)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}