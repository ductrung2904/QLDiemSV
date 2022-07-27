create database QL_DiemSV
go
use QL_DiemSV
go

create table NganhHoc
(
	MaNganh nchar(10) primary key,
	TenNganh nvarchar(50) 
)

create table MonHoc
(
	MaMH char(10) primary key,
	TenMH nvarchar(50),
	SoTinChi int,
	SoTiet int,
	MaNganh nchar(10),
	foreign key(MaNganh) references NganhHoc(MaNganh),
)

create table GiaoVien
(
	MaGV numeric(18, 0) primary key,
	TenGV nvarchar(50),
	GioiTinh nvarchar(3),
	Username varchar(50),
	Password varchar(50),
	Email nvarchar(50),
	Phone nchar(10),
)

create table Lop
(
	MaLop int identity(1, 1) primary key, 
	MaHocPhan char(10),
	SoLuong int,
	MaMH char(10),
	MaGV numeric(18, 0),
	foreign key(MaMH) references MonHoc(MaMH),
	foreign key(MaGV) references GiaoVien(MaGV)
)

create table SinhVien
(
	MaSV numeric(18, 0) primary key,
	TenSV nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(3),
	DiaChi nvarchar(100),
	DienThoai nchar(10),
	MaNganh nchar(10),
	GhiChu nvarchar(100)
	foreign key(MaNganh) references NganhHoc(MaNganh)
)

create table Diem
(
	MaSV numeric(18, 0),
	MaMH char(10),
	MaLop int,
	DiemLT int,
	DiemTH int,
	foreign key(MaSV) references SinhVien(MaSV),
	foreign key(MaMH) references MonHoc(MaMH),
	foreign key(MaLop) references Lop(MaLop)
)

set dateformat dmy
go

insert into NganhHoc values('QTM', N'Quản trị mạng')
insert into NganhHoc values('LT', N'Lập trình')

insert into MonHoc values('TKHTM', N'Triển khai hệ thống mạng', 3, 60, 'QTM')
insert into MonHoc values('MVT', N'Mạng viễn thông', 3, 60, 'QTM')
insert into MonHoc values('ANM', N'An ninh mạng', 3, 60, 'QTM')
insert into MonHoc values('XDHTM', N'Xây dựng hạ tầng mạng', 3, 60, 'QTM')
insert into MonHoc values('PTTKHTM', N'Phân tích thiết kế hệ thống mạng', 3, 60, 'QTM')
insert into MonHoc values('KTLT', N'Kỹ thuật lập trình', 4, 80, 'LT')
insert into MonHoc values('CSDL', N'Cơ sở dữ liệu', 4, 80, 'LT')
insert into MonHoc values('LTW', N'Lập trình Web', 3, 60, 'LT')
insert into MonHoc values('CDN', N'Chuyên đề.NET', 3, 60, 'LT')
insert into MonHoc values('CDJ', N'Chuyên đề Java', 3, 60, 'LT')

insert into GiaoVien values(1110000001, N'Giang Hào Côn', 'Nam', 'ghcon', 'ghcon', 'ghcon@ntt.edu.vn', '0908040502')
insert into GiaoVien values(1110000002, N'Phạm Văn Đăng', 'Nam', 'pvdang', 'pvdang', 'pvdang@ntt.edu.vn', '0903010405')
insert into GiaoVien values(1110000003, N'Nguyễn Xuân Cường', 'Nam', 'nxcuong', 'nxcuong', 'nxcuong@ntt.edu.vn', '0906053801')
insert into GiaoVien values(1110000004, N'Vương Xuân Chí', 'Nam', 'vxchi', 'vxchi', 'vxchi@ntt.edu.vn', '0965892136')
insert into GiaoVien values(1110000005, N'Đặng Như Phú', 'Nam', 'dnphu', 'dnphu', 'dnphu@ntt.edu.vn', '0976736743')
insert into GiaoVien values(1110000006, N'Bùi Duy Tân', 'Nam', 'bdtan', 'bdtan', 'bdtan@ntt.edu.vn', '0983467319')

insert Into Lop values('18DTH2A', 60, 'TKHTM', 1110000004)
insert Into Lop values('18DTH2B', 60, 'TKHTM', 1110000005)
insert Into Lop values('18DTH2C', 60, 'TKHTM', 1110000006)
insert Into Lop values('18DTH2A', 60, 'MVT', 1110000004)
insert Into Lop values('18DTH2B', 60, 'MVT', 1110000004)
insert Into Lop values('18DTH2C', 60, 'MVT', 1110000004)
insert Into Lop values('18DTH1A', 60, 'ANM', 1110000006)
insert Into Lop values('18DTH1B', 60, 'ANM', 1110000006)
insert Into Lop values('18DTH1C', 60, 'ANM', 1110000006)
insert Into Lop values('18DTH1A', 60, 'XDHTM', 1110000004)
insert Into Lop values('18DTH1B', 60, 'XDHTM', 1110000005)
insert Into Lop values('18DTH1C', 60, 'XDHTM', 1110000006)
insert Into Lop values('18DTH1A', 60, 'PTTKHTM', 1110000005)
insert Into Lop values('18DTH1B', 60, 'PTTKHTM', 1110000005)
insert Into Lop values('18DTH1C', 60, 'PTTKHTM', 1110000005)
insert Into Lop values('18DTH1A', 60, 'KTLT', 1110000001)
insert Into Lop values('18DTH1B', 60, 'KTLT', 1110000003)
insert Into Lop values('18DTH1C', 60, 'KTLT', 1110000003)
insert Into Lop values('18DTH1A', 60, 'CSDL', 1110000002)
insert Into Lop values('18DTH1B', 60, 'CSDL', 1110000002)
insert Into Lop values('18DTH1C', 60, 'CSDL', 1110000002)
insert Into Lop values('18DTH2A', 60, 'LTW', 1110000003)
insert Into Lop values('18DTH2B', 60, 'LTW', 1110000001)
insert Into Lop values('18DTH2C', 60, 'LTW', 1110000001)
insert Into Lop values('18DTH2A', 60, 'CDN', 1110000001)
insert Into Lop values('18DTH2B', 60, 'CDN', 1110000001)
insert Into Lop values('18DTH2C', 60, 'CDN', 1110000001)
insert Into Lop values('18DTH2A', 60, 'CDJ', 1110000002)
insert Into Lop values('18DTH2B', 60, 'CDJ', 1110000002)
insert Into Lop values('18DTH2C', 60, 'CDJ', 1110000002)

insert into SinhVien values(1800000001, N'Bùi Nguyễn Đức Trung', '29/04/2000', N'Nam', N'Củ Chi', '0903896224', 'LT', '')
insert into SinhVien values(1800000002, N'Mai Hữu Văn', '21/02/2000', N'Nam', N'222 Cô Bắc Q.1', '0949376324', 'LT', '')
insert into SinhVien values(1800000003, N'Đặng Quốc Lai', '22/12/2000', N'Nam', N'Q. Thủ Đức, TP. HCM', '0772960922', 'LT', '')
insert into SinhVien values(1800000004, N'Nguyễn Sơn Vũ', '25/04/2000', N'Nam', N'Gia Lai', '0949593374', 'LT', '')
insert into SinhVien values(1800000005, N'Dương Khang Hy', '10/07/2000', N'Nam', N'10/6/2A, KP1, TL29, P.Thạnh Lộc, Q34, TP.HCM', '0349939548', 'QTM', '')
insert into SinhVien values(1800000006, N'Đoàn Duy Khánh', '31/08/2000', N'Nam', N'Ấp Bến Chò, xã Thạnh Đức, huyện Gò Gầu, tp Tây Ninh', '0354202739', 'QTM', '')
insert into SinhVien values(1800000007, N'Phạm Minh Thể', '16/07/2000', N'Nam', N'43/46/71/41 vườn lài', '0355521899', 'QTM', '')
insert into SinhVien values(1800000008, N'Huỳnh Quốc Bảo', '14/05/2000', N'Nam', N'123 a mã lò quận bình tân', '0901648465', 'QTM', '')
insert into SinhVien values(1800000009, N'Nguyễn Thanh Phong', '05/10/2000', N'Nam', N'Chí Thạnh - Tuy An - Phú Yên', '0393637275', 'LT', '')
insert into SinhVien values(1800000010, N'Trần Thành Long', '21/02/2000', N'Nam', N'269/29/14 Phú Định p16 q8', '0928248494', 'LT', '')
insert into SinhVien values(1800000011, N'Hứa Ngọc Thiện', '25/10/2000', N'Nam', N'13c đường 20 ấp trung xã tân thông hội huyện củ chi', '0989023841', 'LT', '')
insert into SinhVien values(1800000012, N'Cao Thị Nhung', '14/06/2000', N'Nữ', N'Thôn 6, Hoằng Giang, Hoằng Hóa, Thanh Hóa', '0949376324', 'LT', '')
insert into SinhVien values(1800000013, N'Nguyễn Thị Thu Thủy', '15/06/2000', N'Nữ', N'240 Quang Trung f10 Gò Vấp tp HCM', '0765565904', 'LT', '')
insert into SinhVien values(1800000014, N'Nguyễn Hoàng Hiệp', '25/10/2000', N'Nam', N'73/2L Xuân Thới Đông 3, Hóc Môn', '0932107273', 'LT', '')
insert into SinhVien values(1800000015, N'Nguyễn Thị Kim Anh', '01/07/2000', N'Nữ', N'Tổ 9, Ấp Trung, xã Long Định,huyện Châu Thành, tỉnh Tiền Giang', '0347735730', 'QTM', '')
insert into SinhVien values(1800000016, N'Nguyễn Văn Thái', '10/09/2000', N'Nam', N'Bà Rịa Vũng Tàu', '0406411382', 'QTM', '')
insert into SinhVien values(1800000017, N'Lê Minh Quý', '22/06/2000', N'Nam', N'101/10 ấp tân thới 2 xã tân hiệp huyện Hóc môn', '0964111934', 'QTM', '')
insert into SinhVien values(1800000018, N'Phùng Thành Lộc', '28/06/2000', N'Nam', N'92 An Nhơn ,phường 71 ,Quận Gò vấp ,Hồ Chí Minh', '0406342557', 'LT', '')
insert into SinhVien values(1800000019, N'Lê Võ Quốc An', '31/08/2000', N'Nam', N'34A Nguyễn Thị Định, Phường An Phú, Quận 2', '0969223400', 'LT', '')
insert into SinhVien values(1800000020, N'Nguyễn Văn An', '09/11/2000', N'Nam', N'Tổ 23,ấp 2 Xã Đông Thạnh - Huyện Hóc Môn', '0327070875', 'LT', '')
insert into SinhVien values(1800000021, N'Lê Trung Kiệt', '20/06/2000', N'Nam', N'Phú Yên', '0355309280', 'LT', '')
insert into SinhVien values(1800000022, N'Dương Nguyễn Minh Quốc', '13/04/2000', N'Nam', N'Ấp 15, Tuyên Hòa, Biên Hòa, Đồng Nai', '0555572334', 'LT', '')
insert into SinhVien values(1800000023, N'Lê Thành Song', '09/04/2000', N'Nam', N'Ấp 1, Vĩnh Xương, Tân Châu, An Giang', '0328935998', 'QTM', '')
insert into SinhVien values(1800000024, N'Đỗ Quốc Việt', '13/07/2000', N'Nam', N'48 Hồ Biểu Chánh, P.11, Q.Phú Nhuận', '0932158413', 'QTM', '')

insert into Diem values(1800000001, 'KTLT', 29, 9, 10)

select * 
from SinhVien sv, NganhHoc nh
where sv.MaNganh = nh.MaNganh