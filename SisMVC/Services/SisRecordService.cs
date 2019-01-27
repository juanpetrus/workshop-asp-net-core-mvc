using SisMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SisMVC.Services
{
    public class SisRecordService
    {
        private readonly SisMVCContext _context;

        public SisRecordService(SisMVCContext context)
        {
            _context = context;
        }

        public async Task<List<SisRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {

            var result = from obj in _context.SisRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await  result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
