using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.Models
{
    public class Contractor
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public List<ContractorInvoice> ContractorInvoices { get; set; } = new List<ContractorInvoice>();
    }
}
