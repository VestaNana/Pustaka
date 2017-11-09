using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusViewModel
{
    public class DetailPembelianViewModel
    {
        public int Id { get; set; }

        public string Kode { get; set; }

        public decimal HargaBuku { get; set; }

        public int BeliBuku { get; set; }

        public decimal Total { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
