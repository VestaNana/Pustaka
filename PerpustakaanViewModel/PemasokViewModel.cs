using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanViewModel
{
    public class PemasokViewModel
    {
        public int Id { get; set; }

        public string KodePenerbit { get; set; }

        public string KodePemasok { get; set; }

        public string NamaPemasok { get; set; }

        public string AlamatPemasok { get; set; }

        public string Telepon { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
