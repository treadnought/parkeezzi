using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parkeezzi.ViewModels;

namespace Parkeezzi.Controllers
{
    public class ContractorController : Controller
    {
        public IActionResult Index()
        {
            var model = new ContractorView();
            var invoice = new ContractorView.ContractorInvoice { InvoiceRef = "GB001" };
            var invoice1 = new ContractorView.ContractorInvoice { InvoiceRef = "GB002" };
            var invoice2 = new ContractorView.ContractorInvoice { InvoiceRef = "GB003" };
            var invoice3 = new ContractorView.ContractorInvoice { InvoiceRef = "GB004" };
            model.ContractorInvoices.Add(invoice);
            model.ContractorInvoices.Add(invoice1);
            model.ContractorInvoices.Add(invoice2);
            model.ContractorInvoices.Add(invoice3);
            return View(model);
        }
    }
}