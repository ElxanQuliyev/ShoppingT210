using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services;

namespace UIWeb.Areas.AdminPanel.Controllers
{
    [Area(nameof(AdminPanel))]
    public class AdminProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        public AdminProductController(ProductService productService, CategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        // GET: AdminProductController
        public ActionResult Index()
        {
            return View(_productService.GetAll());
        }

        // GET: AdminProductController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: AdminProductController/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(_categoryService.GetAll(),"Id","Name");
            return View();
        }

        // POST: AdminProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product collection)
        {
            try
            {
                _productService.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product collection)
        {
            try
            {
                _productService.Update(collection);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminProductController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var selectedProduct=_productService.GetById(id.Value);
            if (selectedProduct == null) return NotFound();

            return View(selectedProduct);
        }

        // POST: AdminProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product collection)
        {
            try
            {
                _productService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
