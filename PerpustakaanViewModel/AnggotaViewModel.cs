using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanViewModel
{
    public class AnggotaViewModel
    {
        public int Id { get; set; }

        public string KodePetugas { get; set; }

        public string KodeAnggota { get; set; }

        public string Nama { get; set; }

        public string Alamat { get; set; }

        public string Email { get; set; }

        public string Telepon { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
