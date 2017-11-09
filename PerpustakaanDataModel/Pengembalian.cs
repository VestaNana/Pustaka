namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pengembalian")]
    public partial class Pengembalian
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string KodePengembalian { get; set; }

        [Required]
        [StringLength(10)]
        public string KodePetugas { get; set; }

        [Required]
        [StringLength(10)]
        public string KodeAnggota { get; set; }

        [Required]
        [StringLength(10)]
        public string KodeBuku { get; set; }

        [Required]
        [StringLength(10)]
        public string TglPengembalian { get; set; }

        [Column(TypeName = "money")]
        public decimal Denda { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Buku Buku { get; set; }

        public virtual DetailPengembalian DetailPengembalian { get; set; }
    }
}
