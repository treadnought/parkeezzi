using Microsoft.EntityFrameworkCore;
using Parkeezzi.DataAccess;
using Parkeezzi.Models;
using Parkeezzi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.Services
{
    public class ContractorService
    {
        private readonly ParkeezziContext _context;

        public ContractorService(ParkeezziContext context)
        {
            this._context = context;
        }

        public ContractorList ListContractors()
        {
            var model = new ContractorList();

            foreach (var contractor in _context.Contractors)
            {
                model.Contractors.Add(new ContractorList.Contractor { Id = contractor.Id, Company = contractor.Company });
            }
            //var contractor = new ContractorList.Contractor { Company = "Gold Budgets Pty Ltd" };
            //model.Contractors.Add(contractor);
            return model;
        }

        public void AddContractorInvoice(NewContractorInvoice vm)
        {
            var contractor = _context.Contractors
                .SingleOrDefault(x => x.Id == vm.Id);

            contractor.ContractorInvoices.Add(new ContractorInvoice { InvRef = vm.InvRef });
            _context.SaveChanges();
        }

        public ContractorView GetContractor(int id)
        {
            var model = new ContractorView();

            var contractor = _context.Contractors
               .Include(c => c.ContractorInvoices)
               .ThenInclude(i => i.ContractorInvoiceItems)
               .FirstOrDefault(c => c.Id == id);

            model.Id = contractor.Id;
            model.Company = contractor.Company;

            foreach (var invoice in contractor.ContractorInvoices)
            {
                var modelInvoice = new ContractorView.ContractorInvoice
                {
                    InvRef = invoice.InvRef
                };

                foreach (var item in invoice.ContractorInvoiceItems)
                {
                    var modelItem = new ContractorView.ContractorInvoiceItem
                    {
                        Item = item.Item,
                        Amount = item.Amount,
                        GST = item.GST,
                        Onbill = item.Onbill,
                        ItemNote = item.ItemNote
                    };
                    modelInvoice.ContractorInvoiceItems.Add(modelItem);
                }
                model.ContractorInvoices.Add(modelInvoice);
            }

            //var invoice = new ContractorView.ContractorInvoice { InvoiceRef = "GB001" };
            //var invoice1 = new ContractorView.ContractorInvoice { InvoiceRef = "GB002" };
            //var invoice2 = new ContractorView.ContractorInvoice { InvoiceRef = "GB003" };
            //var invoice3 = new ContractorView.ContractorInvoice { InvoiceRef = "GB004" };
            //model.ContractorInvoices.Add(invoice);
            //model.ContractorInvoices.Add(invoice1);
            //model.ContractorInvoices.Add(invoice2);
            //model.ContractorInvoices.Add(invoice3);
            return model;
        }

        public void AddContractor(NewContractor vm)
        {
            var newContractor = new Contractor { Company = vm.Company };
            _context.Add(newContractor);
            _context.SaveChanges();
        }
    }
}
