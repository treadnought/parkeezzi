using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.ViewModels
{
    public class NewContractor
    {
        [Required]
        public string Company { get; set; }
    }
}
