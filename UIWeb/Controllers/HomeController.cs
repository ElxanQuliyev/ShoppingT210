using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics;
using UIWeb.Models;
using UIWeb.ViewModels;

namespace UIWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ProductService _productService;
        public HomeController(ILogger<HomeController> logger, ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            HomeVM vm = new()
            {
                Products = _productService.GetAll()
            };
            return View(vm);
        }
        
        [Route("tehluke")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}