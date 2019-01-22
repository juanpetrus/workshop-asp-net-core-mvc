using SisMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMVC.Data
{
    public class SeedingService
    {
        private SisMVCContext _context;

        public SeedingService(SisMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {

        }
    }
}
