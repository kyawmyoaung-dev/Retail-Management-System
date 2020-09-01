using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RetailMgmt.Application.Interfaces.OrganizationModule;
using RetailMgmt.WebMVC.Models;
using System.Diagnostics;

namespace RetailMgmt.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICurrencyService _currencyService;
        public HomeController(ILogger<HomeController> logger, ICurrencyService currencyService)
        {
            _logger = logger;
            _currencyService = currencyService;
        }

        public IActionResult Index()
        {
            var test = _currencyService.GetAllCurrencyAsync();
            return View();
        }

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
