drop database QL_DiemSV
go
create database QL_DiemSV
go
use QL_DiemSV
go

create table NganhHoc
(
	MaNganh nchar(10) primary key not null,
	TenNganh nvarchar(50) 
);

create table MonHoc
(
	MaMH char(10) primary key not null,
	TenMH nvarchar(50),
	SoTinChi int,
	SoTiet int,
	MaNganh nchar(10),
	foreign key(MaNganh) references NganhHoc(MaNganh),
);

create table GiaoVien
(
	MaGV int primary key not null,
	TenGV nvarchar(50),
	GioiTinh nvarchar(3),
	Username varchar(50) unique,
	Password varchar(50),
	Email nvarchar(50),
	Phone nchar(10),
);

create table Lop
(
	MaLop char(10) primary key not null, 
	MaHocPhan char(10),
	NoiHoc varchar(20),
	NgayBatDau date,
	NgayKetThuc date,
	SoLuong int,
	MaMH char(10),
	MaGV int,
	foreign key(MaMH) references MonHoc(MaMH),
	foreign key(MaGV) references GiaoVien(MaGV)
);

create table SinhVien
(
	MaSV int primary key not null,
	TenSV nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(3),
	DiaChi nvarchar(100),
	DienThoai nchar(10),
	Username varchar(50) unique,
	Password varchar(50),
	MaNganh nchar(10),
	GhiChu nvarchar(100)
	foreign key(MaNganh) references NganhHoc(MaNganh)
);

create table Diem
(
	MaDiem char(10) primary key not null, 
	MaSV int not null,
	MaMH char(10) not null,
	MaLop char(10) not null,
	DiemLT float,
	DiemTH float,
	DiemTB float,
	DiemHe4 float,
	DiemChu char(3),
	DanhGia nvarchar(10),
	foreign key(MaSV) references SinhVien(MaSV),
	foreign key(MaMH) references MonHoc(MaMH),
	foreign key(MaLop) references Lop(MaLop)
);

set dateformat dmy
go

insert into NganhHoc values('QTM', N'Quản trị mạng');
insert into NganhHoc values('LT', N'Lập trình');

insert into MonHoc values('TKHTM', N'Triển khai hệ thống mạng', 3, 60, 'QTM');
insert into MonHoc values('MVT', N'Mạng viễn thông', 3, 60, 'QTM');
insert into MonHoc values('ANM', N'An ninh mạng', 3, 60, 'QTM');
insert into MonHoc values('XDHTM', N'Xây dựng hạ tầng mạng', 3, 60, 'QTM');
insert into MonHoc values('PTTKHTM', N'Phân tích thiết kế hệ thống mạng', 3, 60, 'QTM');
insert into MonHoc values('KTLT', N'Kỹ thuật lập trình', 4, 80, 'LT');
insert into MonHoc values('CSDL', N'Cơ sở dữ liệu', 4, 80, 'LT');
insert into MonHoc values('LTW', N'Lập trình Web', 3, 60, 'LT');
insert into MonHoc values('CDN', N'Chuyên đề.NET', 3, 60, 'LT');
insert into MonHoc values('CDJ', N'Chuyên đề Java', 3, 60, 'LT');

insert into GiaoVien values(1110000001, N'Giang Hào Côn', 'Nam', 'ghcon', 'ghcon', 'ghcon@ntt.edu.vn', '0908040502');
insert into GiaoVien values(1110000002, N'Phạm Văn Đăng', 'Nam', 'pvdang', 'pvdang', 'pvdang@ntt.edu.vn', '0903010405');
insert into GiaoVien values(1110000003, N'Nguyễn Xuân Cường', 'Nam', 'nxcuong', 'nxcuong', 'nxcuong@ntt.edu.vn', '0906053801');
insert into GiaoVien values(1110000004, N'Vương Xuân Chí', 'Nam', 'vxchi', 'vxchi', 'vxchi@ntt.edu.vn', '0965892136');
insert into GiaoVien values(1110000005, N'Đặng Như Phú', 'Nam', 'dnphu', 'dnphu', 'dnphu@ntt.edu.vn', '0976736743');
insert into GiaoVien values(1110000006, N'Bùi Duy Tân', 'Nam', 'bdtan', 'bdtan', 'bdtan@ntt.edu.vn', '0983467319');

insert Into Lop values('ML00000001', '18DTH2A', 'P.501', '1/7/2022', '11/8/2022', 60, 'TKHTM', 1110000004);
insert Into Lop values('ML00000002', '18DTH2B', 'P.502', '1/7/2022', '11/8/2022', 60, 'TKHTM', 1110000005);
insert Into Lop values('ML00000003', '18DTH2C', 'P.503', '1/7/2022', '11/8/2022', 60, 'TKHTM', 1110000006);
insert Into Lop values('ML00000004', '18DTH2A', 'P.504', '1/7/2022', '11/8/2022', 60, 'MVT', 1110000004);
insert Into Lop values('ML00000005', '18DTH2B', 'P.505', '1/7/2022', '11/8/2022', 60, 'MVT', 1110000004);
insert Into Lop values('ML00000006', '18DTH2C', 'P.506', '1/7/2022', '11/8/2022', 60, 'MVT', 1110000004);
insert Into Lop values('ML00000007', '18DTH1A', 'P.601', '1/7/2022', '11/8/2022', 60, 'ANM', 1110000006);
insert Into Lop values('ML00000008', '18DTH1B', 'P.602', '1/7/2022', '11/8/2022', 60, 'ANM', 1110000006);
insert Into Lop values('ML00000009', '18DTH1C', 'P.603', '1/7/2022', '11/8/2022', 60, 'ANM', 1110000006);
insert Into Lop values('ML00000010', '18DTH1A', 'P.501', '1/7/2022', '11/8/2022', 60, 'XDHTM', 1110000004);
insert Into Lop values('ML00000011', '18DTH1B', 'P.502', '1/7/2022', '11/8/2022', 60, 'XDHTM', 1110000005);
insert Into Lop values('ML00000012', '18DTH1C', 'P.503', '1/7/2022', '11/8/2022', 60, 'XDHTM', 1110000006);
insert Into Lop values('ML00000013', '18DTH1A', 'P.604', '1/7/2022', '11/8/2022', 60, 'PTTKHTM', 1110000005);
insert Into Lop values('ML00000014', '18DTH1B', 'P.605', '1/7/2022', '11/8/2022', 60, 'PTTKHTM', 1110000005);
insert Into Lop values('ML00000015', '18DTH1C', 'P.606', '1/7/2022', '11/8/2022', 60, 'PTTKHTM', 1110000005);
insert Into Lop values('ML00000016', '18DTH1A', 'P.501 & P.203', '1/7/2022', '8/9/2022', 60, 'KTLT', 1110000001);
insert Into Lop values('ML00000017', '18DTH1B', 'P.502 & P.204', '1/7/2022', '8/9/2022', 60, 'KTLT', 1110000003);
insert Into Lop values('ML00000018', '18DTH1C', 'P.503 & P.205', '1/7/2022', '8/9/2022', 60, 'KTLT', 1110000003);
insert Into Lop values('ML00000019', '18DTH1A', 'P.601 & P.201', '1/7/2022', '8/9/2022', 60, 'CSDL', 1110000002);
insert Into Lop values('ML00000020', '18DTH1B', 'P.602 & P.202', '1/7/2022', '8/9/2022', 60, 'CSDL', 1110000002);
insert Into Lop values('ML00000021', '18DTH1C', 'P.603 & P.203', '1/7/2022', '8/9/2022', 60, 'CSDL', 1110000002);
insert Into Lop values('ML00000022', '18DTH2A', 'P.504 & P.204', '1/7/2022', '11/8/2022', 60, 'LTW', 1110000003);
insert Into Lop values('ML00000023', '18DTH2B', 'P.505 & P.205', '1/7/2022', '11/8/2022', 60, 'LTW', 1110000001);
insert Into Lop values('ML00000024', '18DTH2C', 'P.506 & P.206', '1/7/2022', '11/8/2022', 60, 'LTW', 1110000001);
insert Into Lop values('ML00000025', '18DTH2A', 'P.604 & P.201', '1/7/2022', '11/8/2022', 60, 'CDN', 1110000001);
insert Into Lop values('ML00000026', '18DTH2B', 'P.605 & P.202', '1/7/2022', '11/8/2022', 60, 'CDN', 1110000001);
insert Into Lop values('ML00000027', '18DTH2C', 'P.606 & P.203', '1/7/2022', '11/8/2022', 60, 'CDN', 1110000001);
insert Into Lop values('ML00000028', '18DTH2A', 'P.504 & P.204', '1/7/2022', '11/8/2022', 60, 'CDJ', 1110000002);
insert Into Lop values('ML00000029', '18DTH2B', 'P.505 & P.205', '1/7/2022', '11/8/2022', 60, 'CDJ', 1110000002);
insert Into Lop values('ML00000030', '18DTH2C', 'P.506 & P.206', '1/7/2022', '11/8/2022', 60, 'CDJ', 1110000002);

insert into SinhVien values(1800000001, N'Bùi Nguyễn Đức Trung', '29/04/2000', N'Nam', N'Củ Chi', '0903896224', 'bndtrung', 'bndtrung', 'LT', '');
insert into SinhVien values(1800000002, N'Mai Hữu Văn', '21/02/2000', N'Nam', N'222 Cô Bắc Q.1', '0949376324', 'mhvan', 'mhvan', 'LT', '');
insert into SinhVien values(1800000003, N'Đặng Quốc Lai', '22/12/2000', N'Nam', N'Q. Thủ Đức, TP. HCM', '0772960922', 'dqlai', 'dqlai', 'LT', '');
insert into SinhVien values(1800000004, N'Nguyễn Sơn Vũ', '25/04/2000', N'Nam', N'Gia Lai', '0949593374', 'nsvu', 'nsvu', 'LT', '');
insert into SinhVien values(1800000005, N'Dương Khang Hy', '10/07/2000', N'Nam', N'10/6/2A, KP1, TL29, P.Thạnh Lộc, Q34, TP.HCM', '0349939548', 'dkhy', 'dkhy', 'QTM', '');
insert into SinhVien values(1800000006, N'Đoàn Duy Khánh', '31/08/2000', N'Nam', N'Ấp Bến Chò, xã Thạnh Đức, huyện Gò Gầu, tp Tây Ninh', '0354202739', 'ddkhanh', 'ddkhanh', 'QTM', '');
insert into SinhVien values(1800000007, N'Phạm Minh Thể', '16/07/2000', N'Nam', N'43/46/71/41 vườn lài', '0355521899', 'pmthe', 'pmthe', 'QTM', '');
insert into SinhVien values(1800000008, N'Huỳnh Quốc Bảo', '14/05/2000', N'Nam', N'123 a mã lò quận bình tân', '0901648465', 'hqbao', 'hqbao', 'QTM', '');
insert into SinhVien values(1800000009, N'Nguyễn Thanh Phong', '05/10/2000', N'Nam', N'Chí Thạnh - Tuy An - Phú Yên', '0393637275', 'ntphong', 'ntphong', 'LT', '');
insert into SinhVien values(1800000010, N'Trần Thành Long', '21/02/2000', N'Nam', N'269/29/14 Phú Định p16 q8', '0928248494', 'ttlong', 'ttlong', 'LT', '');
insert into SinhVien values(1800000011, N'Hứa Ngọc Thiện', '25/10/2000', N'Nam', N'13c đường 20 ấp trung xã tân thông hội huyện củ chi', '0989023841', 'hnthien', 'hnthien', 'LT', '');
insert into SinhVien values(1800000012, N'Cao Thị Nhung', '14/06/2000', N'Nữ', N'Thôn 6, Hoằng Giang, Hoằng Hóa, Thanh Hóa', '0949376324', 'ctnhung', 'ctnhung', 'LT', '');
insert into SinhVien values(1800000013, N'Nguyễn Thị Thu Thủy', '15/06/2000', N'Nữ', N'240 Quang Trung f10 Gò Vấp tp HCM', '0765565904', 'nttthuy', 'nttthuy', 'LT', '');
insert into SinhVien values(1800000014, N'Nguyễn Hoàng Hiệp', '25/10/2000', N'Nam', N'73/2L Xuân Thới Đông 3, Hóc Môn', '0932107273', 'nhhiep', 'nhhiep', 'LT', '');
insert into SinhVien values(1800000015, N'Nguyễn Thị Kim Anh', '01/07/2000', N'Nữ', N'Tổ 9, Ấp Trung, xã Long Định,huyện Châu Thành, tỉnh Tiền Giang', '0347735730', 'ntkanh', 'ntkanh', 'QTM', '');
insert into SinhVien values(1800000016, N'Nguyễn Văn Thái', '10/09/2000', N'Nam', N'Bà Rịa Vũng Tàu', '0406411382', 'nvthai', 'nvthai', 'QTM', '');
insert into SinhVien values(1800000017, N'Lê Minh Quý', '22/06/2000', N'Nam', N'101/10 ấp tân thới 2 xã tân hiệp huyện Hóc môn', '0964111934', 'lmquy', 'lmquy', 'QTM', '');
insert into SinhVien values(1800000018, N'Phùng Thành Lộc', '28/06/2000', N'Nam', N'92 An Nhơn ,phường 71 ,Quận Gò vấp ,Hồ Chí Minh', '0406342557', 'ptloc', 'ptloc', 'LT', '');
insert into SinhVien values(1800000019, N'Lê Võ Quốc An', '31/08/2000', N'Nam', N'34A Nguyễn Thị Định, Phường An Phú, Quận 2', '0969223400', 'lvqan', 'lvqan', 'LT', '');
insert into SinhVien values(1800000020, N'Nguyễn Văn An', '09/11/2000', N'Nam', N'Tổ 23,ấp 2 Xã Đông Thạnh - Huyện Hóc Môn', '0327070875', 'nvan', 'nvan', 'LT', '');
insert into SinhVien values(1800000021, N'Lê Trung Kiệt', '20/06/2000', N'Nam', N'Phú Yên', '0355309280', 'ltkiet', 'ltkiet', 'LT', '');
insert into SinhVien values(1800000022, N'Dương Nguyễn Minh Quốc', '13/04/2000', N'Nam', N'Ấp 15, Tuyên Hòa, Biên Hòa, Đồng Nai', '0555572334', 'dnmquoc', 'dnmquoc', 'LT', '');
insert into SinhVien values(1800000023, N'Lê Thành Song', '09/04/2000', N'Nam', N'Ấp 1, Vĩnh Xương, Tân Châu, An Giang', '0328935998', 'ltsong', 'ltsong', 'QTM', '');
insert into SinhVien values(1800000024, N'Đỗ Quốc Việt', '13/07/2000', N'Nam', N'48 Hồ Biểu Chánh, P.11, Q.Phú Nhuận', '0932158413', 'dqviet', 'dqviet', 'QTM', '');

insert into Diem values('MD00000001', 1800000001, 'KTLT', 'ML00000016', 9, 10, 9.5, 3.8, 'A', N'Đạt');
insert into Diem values('MD00000002', 1800000001, 'CSDL', 'ML00000019', 3, 3, 3, 1.2, 'D', N'Thi lại');
insert into Diem values('MD00000003', 1800000001, 'LTW', 'ML00000022', 9, 9, 9, 3.6, 'A', N'Đạt');
insert into Diem values('MD00000004', 1800000002, 'LTW', 'ML00000023', 8, 9, 8.5, 3.4, 'A', N'Đạt');
insert into Diem values('MD00000005', 1800000002, 'CDN', 'ML00000026', 6, 7, 6.5, 2.6, 'C', N'Đạt');
insert into Diem values('MD00000006', 1800000005, 'TKHTM', 'ML00000001', 8, 9, 8.5, 3.4, 'A', N'Đạt');
insert into Diem values('MD00000007', 1800000006, 'ANM', 'ML00000009', 7, 4, 5.5, 2.2, 'D', N'Đạt');
insert into Diem values('MD00000008', 1800000024, 'PTTKHTM', 'ML00000014', 4, null, null, null, null, null);

select * from NganhHoc;
select * from MonHoc;
select * from GiaoVien;
select * from Lop;
select * from SinhVien;
select * from Diem;
