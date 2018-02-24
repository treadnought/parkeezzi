using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.ViewModels
{
    public class NewContractorInvoice
    {
        public int Id { get; set; }
        [Required]
        public string InvRef { get; set; }
    }
}
