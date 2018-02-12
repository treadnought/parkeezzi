using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parkeezzi.ViewModels;

namespace Parkeezzi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new ContractorList();
            var contractor = new ContractorList.Contractor { Company = "Gold Budgets Pty Ltd" };
            model.Contractors.Add(contractor);
            return View(model);
        }
    }
}