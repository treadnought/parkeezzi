using Parkeezzi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkeezzi.ViewModels
{
    public class ContractorView
    {
        public int Id { get; set; }
        public string Company { get; set; }

        public List<ContractorInvoice> ContractorInvoices { get; set; } = new List<ContractorInvoice>();

        public class ContractorInvoice
        {
            public string InvRef { get; set; }
            public List<ContractorInvoiceItem> ContractorInvoiceItems { get; set; } = new List<ContractorInvoiceItem>();
        }

        public class ContractorInvoiceItem
        {
            public string Item { get; set; }
            public double Amount { get; set; }
            public bool GST { get; set; }
            public bool Onbill { get; set; }
            public string ItemNote { get; set; }
        }
    }
}
