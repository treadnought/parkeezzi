using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.ViewModels
{
    public class ContractorList
    {
        public List<Contractor> Contractors { get; set; } = new List<Contractor>();
        public class Contractor
        {
            public string Company { get; set; }
        }
    }
}
