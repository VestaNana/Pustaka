namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pembelian")]
    public partial class Pembelian
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string KodePemasok { get; set; }

        [Required]
        [StringLength(10)]
        public string KodePetugas { get; set; }

        public DateTime TglPembelian { get; set; }

        [Column(TypeName = "money")]
        public decimal HargaBuku { get; set; }

        [Required]
        [StringLength(10)]
        public string NoReferensi { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual DetailPembelian DetailPembelian { get; set; }

        public virtual Pemasok Pemasok { get; set; }

        public virtual Petugas Petugas { get; set; }
    }
}
