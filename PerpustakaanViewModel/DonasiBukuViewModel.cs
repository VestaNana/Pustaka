using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusViewModel
{
    public class DonasiBukuViewModel
    {
        public int Id { get; set; }

        public string KodeDonasi { get; set; }

        public string NamaPenerbit { get; set; }

        public string NamaDonatur { get; set; }

        public string KodePetugas { get; set; }

        public string NamaPetugas { get; set; }

        public DateTime TglDonasi { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
