using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanViewModel
{
    public class BukuViewModel
    {
       public int Id { get; set; }

        public string KodeBuku { get; set; }

        public string Kategori { get; set; }

        public string KodePenerbit { get; set; }

        public string JudulBuku { get; set; }

        public int jumlahBuku { get; set; }

        public string Pengarang { get; set; }

        public int TahunTerbit { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
