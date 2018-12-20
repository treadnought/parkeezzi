using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parkeezzi.Services;
using Parkeezzi.ViewModels;

namespace Parkeezzi.Controllers
{
    public class ContractorController : Controller
    {
        private readonly ContractorService _contractorService;

        public ContractorController(ContractorService contractorService)
        {
            _contractorService = contractorService;
        }
        public IActionResult Index(int id)
        {
            ContractorView model = _contractorService.GetContractor(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult AddContractorInvoice(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContractorInvoice(NewContractorInvoice vm)
        {
            if (ModelState.IsValid)
            {
                _contractorService.AddContractorInvoice(vm);
                return RedirectToAction(nameof(Index), new { id = vm.Id });
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult AddContractorInvoiceItem(int Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContractorInvoiceItem(int invoiceId, NewContractorInvoiceItem vm)
        {
            if (ModelState.IsValid)
            {
                _contractorService.AddContractorInvoiceItem(vm);
                return RedirectToAction(nameof(Index), new { id = vm.InvoiceId });
            }
            return View(vm);
        }
    }
}