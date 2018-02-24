using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parkeezzi.Services;
using Parkeezzi.ViewModels;

namespace Parkeezzi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContractorService _contractorService;

        public HomeController(ContractorService contractorService)
        {
            _contractorService = contractorService;
        }
        public IActionResult Index()
        {
            ContractorList model = _contractorService.ListContractors();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddContractor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContractor(NewContractor vm)
        {
            if (ModelState.IsValid)
            {
                _contractorService.AddContractor(vm);
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }
    }
}