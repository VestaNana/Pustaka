namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailPengembalian")]
    public partial class DetailPengembalian
    {
        public DetailPengembalian()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string JudulBuku { get; set; }

        [Required]
        [StringLength(50)]
        public string NamaPengarang { get; set; }

        public int TahunTerbit { get; set; }

        public int JumlahBuku { get; set; }

        public virtual ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
