namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pemasok")]
    public partial class Pemasok
    {
        public Pemasok()
        {
            Pembelian = new HashSet<Pembelian>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string KodePenerbit { get; set; }

        [Key]
        [StringLength(20)]
        public string KodePemasok { get; set; }

        [Required]
        [StringLength(10)]
        public string NamaPemasok { get; set; }

        [Required]
        [StringLength(500)]
        public string AlamatPemasok { get; set; }

        [Required]
        [StringLength(12)]
        public string Telepon { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<Pembelian> Pembelian { get; set; }
    }
}
