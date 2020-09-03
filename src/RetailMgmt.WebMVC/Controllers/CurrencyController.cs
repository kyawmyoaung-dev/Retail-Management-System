using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetailMgmt.Application.ViewModels.OrganizationModule.Currency;

namespace RetailMgmt.WebMVC.Controllers
{
    public class CurrencyController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CurrencyCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(CurrencyCreateViewModel model)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }
    }
}