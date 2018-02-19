using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.Models
{
    public class ContractorInvoiceItem
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public double Amount { get; set; }
        public bool GST { get; set; }
        public bool Onbill { get; set; }
        public string ItemNote { get; set; }
        public int ContractorInvoiceId { get; set; }
        public ContractorInvoice ContractorInvoice { get; set; }
    }
}
