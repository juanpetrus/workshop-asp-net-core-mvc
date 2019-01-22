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

        public DbSet<SisMVC.Models.Department> Department { get; set; }
    }
}
