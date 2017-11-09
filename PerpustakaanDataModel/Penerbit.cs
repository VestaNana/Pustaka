namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Penerbit")]
    public partial class Penerbit
    {
        public Penerbit()
        {
            Buku = new HashSet<Buku>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(20)]
        public string KodePenerbit { get; set; }

        [Required]
        [StringLength(100)]
        public string NamaPenerbit { get; set; }

        [Required]
        [StringLength(500)]
        public string AlamatPenerbit { get; set; }

        [Required]
        [StringLength(12)]
        public string Telepon { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<Buku> Buku { get; set; }
    }
}
