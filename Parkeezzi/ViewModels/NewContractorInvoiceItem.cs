using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.ViewModels
{
    public class NewContractorInvoiceItem
    {
        [Required]
        public string Item { get; set; }
        [Required]
        public double Amount { get; set; }
        public bool GST { get; set; }
        public bool Onbill { get; set; }
        public string ItemNote { get; set; }
    }
}
