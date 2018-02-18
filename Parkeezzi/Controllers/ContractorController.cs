﻿using System;
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
    }
}