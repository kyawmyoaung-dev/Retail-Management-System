using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RetailMgmt.Application.Dtos.OrganizationModule.Currency;
using RetailMgmt.Application.Interfaces.OrganizationModule.Currency;
using RetailMgmt.WebMVC.Models;
using System.Diagnostics;
using System.Threading.Tasks;

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

        public async Task<IActionResult> Index()
        {
            //var test = await _currencyService.GetPagedListAsync(new CurrencyListInputDto{ PageNumber = 0, PageSize = 1 });
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
