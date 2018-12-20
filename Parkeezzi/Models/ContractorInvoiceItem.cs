using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.Models
{
    public class ContractorInvoiceItem
    {
        public int Id { get; set; }
        [Required]
        public string Item { get; set; }
        [Required]
        public double Amount { get; set; }
        public bool GST { get; set; } = true;
        public bool Onbill { get; set; } = false;
        public string ItemNote { get; set; }
        public int ContractorInvoiceId { get; set; }
        public ContractorInvoice ContractorInvoice { get; set; }
    }
}
