using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departements { get; set; }
    }
}
