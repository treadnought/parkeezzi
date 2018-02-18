using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.Models
{
    public class ContractorInvoice
    {
        public int Id { get; set; }
        public string InvRef { get; set; }
        public int ContractorId { get; set; }
        public Contractor Contractor { get; set; }
    }
}
