using Parkeezzi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkeezzi.ViewModels
{
   public class ContractorView
   {
      public List<ContractorInvoice> ContractorInvoices { get; set; } = new List<ContractorInvoice>();

      public class ContractorInvoice
      {
         public string ContractorInvoiceRef { get; set; }
      }
   }
}
