using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusViewModel
{
    public class PembelianViewModel
    {
        public int Id { get; set; }

        public string NoReferensi { get; set; }

        public string KodePemasok { get; set; }

        public string NamaPemasok { get; set; }

        public string KodePetugas { get; set; }

        public string NamaPetugas { get; set; }

        public DateTime TglPembelian { get; set; }

        public decimal HargaBuku { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
