namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Petugas
    {
        public Petugas()
        {
            Anggota = new HashSet<Anggota>();
            Pembelian = new HashSet<Pembelian>();
            Peminjaman = new HashSet<Peminjaman>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string KodePetugas { get; set; }

        [Required]
        [StringLength(10)]
        public string Nama { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<Anggota> Anggota { get; set; }

        public virtual ICollection<Pembelian> Pembelian { get; set; }

        public virtual ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
