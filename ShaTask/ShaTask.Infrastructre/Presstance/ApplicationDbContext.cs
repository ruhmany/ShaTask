using Microsoft.EntityFrameworkCore;
using ShaTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Infrastructre.Presstance
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Cashier> Cashiers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<InvoiceHeader> InvoiceHeaders { get; set; }
    }
}
