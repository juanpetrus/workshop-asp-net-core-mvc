using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMVC.Models.Enums
{
    public enum SisStatus : int
    {
        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}
