using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SisMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SisMVC.Services
{
    public class DepartmentService
    {
        private readonly SisMVCContext _context;

        public DepartmentService(SisMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
