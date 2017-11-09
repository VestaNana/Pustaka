create table
Anggota				
(Id	int	not null identity(1,1),
Kd_Anggota	varchar	(10) not null,
Nama varchar	(100)	not null,		
Alamat varchar	(500)	not null,		
Email varchar	(30) not null,		
Telp varchar (15) not null)		
create table
Buku				
(Id	int identity(1,1) not null,	
Kd_Buku	varchar	(10) not null,
Kategori	varchar	(20) not null,		
Penerbit	varchar	(20) not null,		
Judul_Buku	varchar	(50) not null,		
jumlah_Buku	int	not null,		
Pengarang varchar	(100)	not null,		
Tahun_Terbit int	not null)		
					
create table
Penerbit				
(Id	int identity(1,1)	not null,	
Kd_Penerbit	varchar	(10) not null,
Alamat	varchar	(500) not null,		
Telp	varchar (12)	not null)		
					
create table
Petugas				
(Id	int	not null identity(1,1),
Kd_Petugas	varchar	(10) not null,
Nama	varchar	(10) not null)		
					
create table					
Peminjaman				
(Id	int	identity(1,1) not null,	
Kd_Peminjaman	varchar	(10)	not null,
Kd_Petugas	varchar	(10)	not null,		
Kd_Anggota	varchar	(10)	not null,		
Nama	varchar	(100)	not null)		
					
create table
DetailPeminjaman				
(Id	int	not null identity(1,1),
kd_Peminjaman	varchar	(10) not null,		
Kd_Buku	varchar	(10) not null,		
Tgl_Kembali	datetime not null,		
Status_Kembli	varchar	(20) not null)		
					
create table
Pendaftaran				
(Id	int	identity(1,1) not null,
Kd_Kartu	varchar	(10)	not null,
Kd_Petugas	varchar	(10)	not null,		
Kd_Anggota	varchar	(10)	not null,		
Tgl_Pembuatan	datetime not null,		
Tgl_Expired	datetime not null,		
Status_Kembali	bit	not null)		
					
create table
Pengembalian				
(Id	int	identity(1,1) not null,	
Kd_Pengembalian	varchar	(10) not null,
Kd_Petugas	varchar	(10) not null,		
Kd_Anggota	varchar	(10) not null,		
Judul_Buku	varchar	(50) not null,		
Tgl_Kembali	datetime not null,		
Denda	money not null)		
