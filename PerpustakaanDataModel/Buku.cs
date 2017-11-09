namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buku")]
    public partial class Buku
    {
        public Buku()
        {
            DetailDonasiBuku = new HashSet<DetailDonasiBuku>();
            DetailPembelian = new HashSet<DetailPembelian>();
            DetailPeminjaman = new HashSet<DetailPeminjaman>();
            Pengembalian = new HashSet<Pengembalian>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string KodeBuku { get; set; }

        [Required]
        [StringLength(20)]
        public string Kategori { get; set; }

        [Required]
        [StringLength(20)]
        public string KodePenerbit { get; set; }

        [Required]
        [StringLength(50)]
        public string JudulBuku { get; set; }

        public int jumlahBuku { get; set; }

        [Required]
        [StringLength(100)]
        public string Pengarang { get; set; }

        public int TahunTerbit { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Penerbit Penerbit { get; set; }

        public virtual ICollection<DetailDonasiBuku> DetailDonasiBuku { get; set; }

        public virtual ICollection<DetailPembelian> DetailPembelian { get; set; }

        public virtual ICollection<DetailPeminjaman> DetailPeminjaman { get; set; }

        public virtual ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
