using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SisMVC.Models
{
    public class SisMVCContext : DbContext
    {
        public SisMVCContext (DbContextOptions<SisMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SisRecord> SisRecord { get; set; }
    }
}
