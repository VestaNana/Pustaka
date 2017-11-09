using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanViewModel
{
    public class PenerbitViewModel
    {
        public int Id { get; set; }

        public string KodePenerbit { get; set; }

        public string NamaPenerbit { get; set; }

        public string AlamatPenerbit { get; set; }

        public string Telepon { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
