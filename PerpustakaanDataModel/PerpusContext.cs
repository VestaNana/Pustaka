namespace PerpustakaanDataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PerpusContext : DbContext
    {
        public PerpusContext()
            : base("name=PerpusContext")
        {
        }

        public virtual DbSet<Anggota> Anggota { get; set; }
        public virtual DbSet<Buku> Buku { get; set; }
        public virtual DbSet<DetailDonasiBuku> DetailDonasiBuku { get; set; }
        public virtual DbSet<DetailPembelian> DetailPembelian { get; set; }
        public virtual DbSet<DetailPeminjaman> DetailPeminjaman { get; set; }
        public virtual DbSet<DetailPengembalian> DetailPengembalian { get; set; }
        public virtual DbSet<DonasiBuku> DonasiBuku { get; set; }
        public virtual DbSet<Pemasok> Pemasok { get; set; }
        public virtual DbSet<Pembelian> Pembelian { get; set; }
        public virtual DbSet<Peminjaman> Peminjaman { get; set; }
        public virtual DbSet<Penerbit> Penerbit { get; set; }
        public virtual DbSet<Pengembalian> Pengembalian { get; set; }
        public virtual DbSet<Petugas> Petugas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anggota>()
                .Property(e => e.KodePetugas)
                .IsUnicode(false);

            modelBuilder.Entity<Anggota>()
                .Property(e => e.KodeAnggota)
                .IsUnicode(false);

            modelBuilder.Entity<Anggota>()
                .Property(e => e.Nama)
                .IsUnicode(false);

            modelBuilder.Entity<Anggota>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<Anggota>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Anggota>()
                .Property(e => e.Telepon)
                .IsUnicode(false);

            modelBuilder.Entity<Anggota>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Anggota>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Buku>()
                .Property(e => e.KodeBuku)
                .IsUnicode(false);

            modelBuilder.Entity<Buku>()
                .Property(e => e.Kategori)
                .IsUnicode(false);

            modelBuilder.Entity<Buku>()
                .Property(e => e.KodePenerbit)
                .IsUnicode(false);

            modelBuilder.Entity<Buku>()
                .Property(e => e.JudulBuku)
                .IsUnicode(false);

            modelBuilder.Entity<Buku>()
                .Property(e => e.Pengarang)
                .IsUnicode(false);

            modelBuilder.Entity<Buku>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Buku>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Buku>()
                .HasMany(e => e.DetailDonasiBuku)
                .WithRequired(e => e.Buku)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buku>()
                .HasMany(e => e.DetailPembelian)
                .WithRequired(e => e.Buku)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buku>()
                .HasMany(e => e.DetailPeminjaman)
                .WithRequired(e => e.Buku)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buku>()
                .HasMany(e => e.Pengembalian)
                .WithRequired(e => e.Buku)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DetailDonasiBuku>()
                .Property(e => e.Kategori)
                .IsUnicode(false);

            modelBuilder.Entity<DetailDonasiBuku>()
                .Property(e => e.KodePenerbit)
                .IsUnicode(false);

            modelBuilder.Entity<DetailDonasiBuku>()
                .Property(e => e.KodeBuku)
                .IsUnicode(false);

            modelBuilder.Entity<DetailDonasiBuku>()
                .Property(e => e.JudulBuku)
                .IsUnicode(false);

            modelBuilder.Entity<DetailDonasiBuku>()
                .Property(e => e.NamaPengarang)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.KodePenerbit)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.KodeBuku)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.JudulBuku)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.NamaPengarang)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.Kategori)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.HargaBuku)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPembelian>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPembelian>()
                .HasOptional(e => e.Pembelian)
                .WithRequired(e => e.DetailPembelian);

            modelBuilder.Entity<DetailPeminjaman>()
                .Property(e => e.KodePeminjaman)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPeminjaman>()
                .Property(e => e.KodeBuku)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPeminjaman>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPeminjaman>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPengembalian>()
                .Property(e => e.JudulBuku)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPengembalian>()
                .Property(e => e.NamaPengarang)
                .IsUnicode(false);

            modelBuilder.Entity<DetailPengembalian>()
                .HasMany(e => e.Pengembalian)
                .WithRequired(e => e.DetailPengembalian)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonasiBuku>()
                .Property(e => e.KodePetugas)
                .IsUnicode(false);

            modelBuilder.Entity<DonasiBuku>()
                .Property(e => e.NamaDonatur)
                .IsUnicode(false);

            modelBuilder.Entity<DonasiBuku>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DonasiBuku>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DonasiBuku>()
                .HasOptional(e => e.DetailDonasiBuku)
                .WithRequired(e => e.DonasiBuku);

            modelBuilder.Entity<Pemasok>()
                .Property(e => e.KodePenerbit)
                .IsUnicode(false);

            modelBuilder.Entity<Pemasok>()
                .Property(e => e.KodePemasok)
                .IsUnicode(false);

            modelBuilder.Entity<Pemasok>()
                .Property(e => e.NamaPemasok)
                .IsUnicode(false);

            modelBuilder.Entity<Pemasok>()
                .Property(e => e.AlamatPemasok)
                .IsUnicode(false);

            modelBuilder.Entity<Pemasok>()
                .Property(e => e.Telepon)
                .IsUnicode(false);

            modelBuilder.Entity<Pemasok>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Pemasok>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Pemasok>()
                .HasMany(e => e.Pembelian)
                .WithRequired(e => e.Pemasok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pembelian>()
                .Property(e => e.KodePemasok)
                .IsUnicode(false);

            modelBuilder.Entity<Pembelian>()
                .Property(e => e.KodePetugas)
                .IsUnicode(false);

            modelBuilder.Entity<Pembelian>()
                .Property(e => e.HargaBuku)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pembelian>()
                .Property(e => e.NoReferensi)
                .IsUnicode(false);

            modelBuilder.Entity<Pembelian>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Pembelian>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Peminjaman>()
                .Property(e => e.KodePeminjaman)
                .IsUnicode(false);

            modelBuilder.Entity<Peminjaman>()
                .Property(e => e.KodePetugas)
                .IsUnicode(false);

            modelBuilder.Entity<Peminjaman>()
                .Property(e => e.KodeAnggota)
                .IsUnicode(false);

            modelBuilder.Entity<Peminjaman>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Peminjaman>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Peminjaman>()
                .HasMany(e => e.DetailPeminjaman)
                .WithRequired(e => e.Peminjaman)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Penerbit>()
                .Property(e => e.KodePenerbit)
                .IsUnicode(false);

            modelBuilder.Entity<Penerbit>()
                .Property(e => e.NamaPenerbit)
                .IsUnicode(false);

            modelBuilder.Entity<Penerbit>()
                .Property(e => e.AlamatPenerbit)
                .IsUnicode(false);

            modelBuilder.Entity<Penerbit>()
                .Property(e => e.Telepon)
                .IsUnicode(false);

            modelBuilder.Entity<Penerbit>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Penerbit>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Penerbit>()
                .HasMany(e => e.Buku)
                .WithRequired(e => e.Penerbit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pengembalian>()
                .Property(e => e.KodePengembalian)
                .IsUnicode(false);

            modelBuilder.Entity<Pengembalian>()
                .Property(e => e.KodePetugas)
                .IsUnicode(false);

            modelBuilder.Entity<Pengembalian>()
                .Property(e => e.KodeAnggota)
                .IsUnicode(false);

            modelBuilder.Entity<Pengembalian>()
                .Property(e => e.KodeBuku)
                .IsUnicode(false);

            modelBuilder.Entity<Pengembalian>()
                .Property(e => e.TglPengembalian)
                .IsFixedLength();

            modelBuilder.Entity<Pengembalian>()
                .Property(e => e.Denda)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pengembalian>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Pengembalian>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Petugas>()
                .Property(e => e.KodePetugas)
                .IsUnicode(false);

            modelBuilder.Entity<Petugas>()
                .Property(e => e.Nama)
                .IsUnicode(false);

            modelBuilder.Entity<Petugas>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Petugas>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Petugas>()
                .HasMany(e => e.Anggota)
                .WithRequired(e => e.Petugas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Petugas>()
                .HasMany(e => e.Pembelian)
                .WithRequired(e => e.Petugas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Petugas>()
                .HasMany(e => e.Peminjaman)
                .WithRequired(e => e.Petugas)
                .WillCascadeOnDelete(false);
        }
    }
}
