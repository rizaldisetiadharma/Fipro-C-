create database Fipro

on primary
(
	name ='Fipro',
	filename = 'D:\Fixed\FiPro\FiPro\Fipro.mdf',
	size = 5,
	maxsize = 10,
	filegrowth = 2
)

log on 
(
	name ='Fipro_Log',
	filename = 'D:\Fixed\FiPro\FiPro\Fipro_log.ldf',
	size = 2,
	maxsize = 10,
	filegrowth = 2
)

use Fipro

create table Guru
(
	NIP char(8) primary key not null,
	Nama varchar (30) not null,
	TanggalLahir datetime,
	Gender char(1) check(Gender='L' or Gender ='P'), 
	Alamat varchar (30),
	Pwd varchar (10)
)

create table DaftarSanksi
(
	[Kode Aturan] varchar(4) primary key not null,
	NamaAturan varchar (50) not null,
	Point numeric ,
	Sanksi char (100)
)



create table Siswa
(
	NIS varchar (4) primary key not null,
	NamaSiswa varchar (30) not null,
	Gender char(1) check(Gender='L' or Gender ='P'), 
	TempatLahir varchar (15) not null,
	TanggalLahir date,
	Alamat varchar (30), 
	Kelas char (20),
	Point numeric
)





select * from Guru

insert into Guru(NIP, Nama, TanggalLahir, Gender, Alamat, Pwd )
values ('00000001', 'Rojali', '12/12/1964', 'L', 'Jl.Perumnas No.41',12345)
insert into Guru(NIP, Nama, TanggalLahir, Gender, Alamat ,Pwd)
values ('00000002', 'Sumirnah', '07/11/1972', 'P', 'Jl.Seturan 2 Blok A No.12',12345)
insert into Guru(NIP, Nama, TanggalLahir, Gender, Alamat ,Pwd)
values ('00000003', 'Anna Karina', '09/10/1977', 'P', 'Jl.Bunga No.3',12345)
insert into Guru(NIP, Nama, TanggalLahir, Gender, Alamat ,Pwd)
values ('00000004', 'Tri Wibowo', '01/21/1980', 'L', 'Jl.Dahlia No.20',12345)
insert into Guru(NIP, Nama, TanggalLahir, Gender, Alamat ,Pwd)
values ('00000005', 'Mia Ekasati', '05/25/1973', 'P', 'Komp. walikota Blok 2D/11',12345)
insert into Guru(NIP, Nama, TanggalLahir, Gender, Alamat ,Pwd)
values ('00000006', 'Yustinus Leonard', '07/12/1978', 'L', 'Komp. Nusa 3 No.9',12345)



select * from DaftarSanksi

insert into DaftarSanksi([Kode Aturan], NamaAturan, Point, Sanksi )
values ('S001','Perlengkapan atribut seragam', '2', 'Dapat poin sanksi')
insert into DaftarSanksi([Kode Aturan], NamaAturan, Point, Sanksi )
values ('S002','Mengotori lingkungan', '5', 'Dapat poin sanksi dan membersihkan')
insert into DaftarSanksi([Kode Aturan], NamaAturan, Point, Sanksi )
values ('S003', 'Terlambat masuk jam Pelajaran', '10', 'Dapat poin sanksi dan berdiri hormat di lapangan upacara bendera')
insert into DaftarSanksi([Kode Aturan], NamaAturan, Point, Sanksi )
values ('S004', 'Mencontek pada saat ujian', '20', 'Dapat poin sanksi dan nilai hasil ujian diptong 50%')
insert into DaftarSanksi([Kode Aturan], NamaAturan, Point, Sanksi )
values ('S005', 'Memakai Tatto/Membawa Senjata Tajam/Api', '50', 'Dapat poin sanksi dan langsung Pemanggilan orang tua murid')
insert into DaftarSanksi([Kode Aturan], NamaAturan, Point, Sanksi )
values ('S006', 'Mengkonsumsi Minuman Keras dan Narkoba', '100', 'Dikeluarkan dari sekolah')



select * from Siswa
insert into Siswa(NIS, NamaSiswa, Gender, TempatLahir, TanggalLahir, Alamat, Kelas, Point )
values ('0001', 'Budi', 'L', 'Jakarta', '12/12/1998', 'Jl.Bunga', 'X TKJ 2', 0)
insert into Siswa(NIS, NamaSiswa, Gender, TempatLahir, TanggalLahir, Alamat, Kelas, Point)
values ('0002', 'Ipin', 'L', 'Temanggung',' 08/27/1998', 'Jl.Dahlia', 'X TKJ 2', 0)


create table Siswa
(
	NIS varchar (4) primary key not null,
	NamaSiswa varchar (30) not null,
	Gender char(1) check(Gender='L' or Gender ='P'), 
	TempatLahir varchar (15) not null,
	TanggalLahir varchar (15),
	Alamat varchar (30), 
	Kelas char (7),
	Point numeric
)



select * from siswa

update siswa set point = Point + 4 where nis=0001

select point from DaftarSanksi where [Kode Aturan] = 'S001'
select * from DaftarSanksi

update siswa set Point = point + (select point from DaftarSanksi where [Kode Aturan] = 'S002') where nis=0002