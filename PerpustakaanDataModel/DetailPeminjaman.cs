namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailPeminjaman")]
    public partial class DetailPeminjaman
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string KodePeminjaman { get; set; }

        [Required]
        [StringLength(10)]
        public string KodeBuku { get; set; }

        public DateTime TglPinjam { get; set; }

        public DateTime InfoPengembalian { get; set; }

        public int JumlahBuku { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Buku Buku { get; set; }

        public virtual Peminjaman Peminjaman { get; set; }
    }
}
