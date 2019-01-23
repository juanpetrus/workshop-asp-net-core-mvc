using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SisMVC.Models;

namespace SisMVC.Services
{
    public class DepartmentService
    {
        private readonly SisMVCContext _context;

        public DepartmentService(SisMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
