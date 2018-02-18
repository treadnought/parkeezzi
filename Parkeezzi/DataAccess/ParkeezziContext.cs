using Microsoft.EntityFrameworkCore;
using Parkeezzi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkeezzi.DataAccess
{
    public class ParkeezziContext : DbContext
    {
        public ParkeezziContext(DbContextOptions<ParkeezziContext> options)
            :base(options)
        {
            
        }

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ContractorInvoice> ContractorInvoices { get; set; }
    }
}
