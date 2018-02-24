using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.Models
{
    public class ContractorInvoice
    {
        public int Id { get; set; }
        [Required]
        public string InvRef { get; set; }
        public List<ContractorInvoiceItem> ContractorInvoiceItems { get; set; } 
            = new List<ContractorInvoiceItem>();
        public int ContractorId { get; set; }
        public Contractor Contractor { get; set; }
    }
}
