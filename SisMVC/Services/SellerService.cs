using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SisMVC.Models;

namespace SisMVC.Services
{
    public class SellerService
    {
        private readonly SisMVCContext _context;

        public SellerService(SisMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
