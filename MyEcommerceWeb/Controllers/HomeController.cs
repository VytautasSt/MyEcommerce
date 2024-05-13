using Microsoft.AspNetCore.Mvc;
using MyEcommerceWeb.Models;
using MyEcommerceWeb.Models.Repositories;
using System.Diagnostics;

namespace MyEcommerceWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Product> _producrRepo;

        public HomeController(IRepository<Product> producrRepo, ILogger<HomeController> logger)
        {
            _logger = logger;
            _producrRepo = producrRepo;
            logger.LogInformation($"MyEcommerce web is running in '{Process.GetCurrentProcess().ProcessName}' process");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Catalog()//lets say id is 1
        {
            if (false)
            {
                // display all
                return View(null);
            }
            var product = _producrRepo.Get(1);
            ViewBag.PageTitle = "Product details";
            return View(product);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
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
