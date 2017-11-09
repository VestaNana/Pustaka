namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Peminjaman")]
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            DetailPeminjaman = new HashSet<DetailPeminjaman>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string KodePeminjaman { get; set; }

        [Required]
        [StringLength(10)]
        public string KodePetugas { get; set; }

        [Required]
        [StringLength(10)]
        public string KodeAnggota { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<DetailPeminjaman> DetailPeminjaman { get; set; }

        public virtual Petugas Petugas { get; set; }
    }
}
