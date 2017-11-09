namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailPembelian")]
    public partial class DetailPembelian
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string KodePenerbit { get; set; }

        [Required]
        [StringLength(10)]
        public string KodeBuku { get; set; }

        [Required]
        [StringLength(50)]
        public string JudulBuku { get; set; }

        [Required]
        [StringLength(50)]
        public string NamaPengarang { get; set; }

        [Required]
        [StringLength(20)]
        public string Kategori { get; set; }

        public int TahunTerbit { get; set; }

        [Column(TypeName = "money")]
        public decimal HargaBuku { get; set; }

        public int JumlahBuku { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Buku Buku { get; set; }

        public virtual Pembelian Pembelian { get; set; }
    }
}
