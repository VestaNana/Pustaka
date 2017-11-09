namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailDonasiBuku")]
    public partial class DetailDonasiBuku
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Kategori { get; set; }

        [Required]
        [StringLength(10)]
        public string KodePenerbit { get; set; }

        [Required]
        [StringLength(10)]
        public string KodeBuku { get; set; }

        [Required]
        [StringLength(50)]
        public string JudulBuku { get; set; }

        [Required]
        [StringLength(100)]
        public string NamaPengarang { get; set; }

        public int TahunTerbit { get; set; }

        public int JumlahBuku { get; set; }

        public virtual Buku Buku { get; set; }

        public virtual DonasiBuku DonasiBuku { get; set; }
    }
}
