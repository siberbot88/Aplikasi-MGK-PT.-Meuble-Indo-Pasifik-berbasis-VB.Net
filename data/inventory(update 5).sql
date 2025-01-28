-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 22, 2024 at 04:07 PM
-- Server version: 10.4.32-MariaDB-log
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `kd_admin` varchar(15) NOT NULL,
  `username` varchar(12) NOT NULL,
  `userpass` varchar(12) NOT NULL,
  `divisi` varchar(1) NOT NULL COMMENT '0=master, 1=gudang, 2=pembelian, 3=penjualan'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`kd_admin`, `username`, `userpass`, `divisi`) VALUES
('1111', 'accMaster', 'admin', '0'),
('1824160632war1', 'Gudang002', '002', '1'),
('1824190242Gud1', 'Gudang001', '001', '1'),
('1924120913aku0', 'akunbayu', '1921', '0');

-- --------------------------------------------------------

--
-- Table structure for table `barang_closing`
--

CREATE TABLE `barang_closing` (
  `ID_closing` varchar(10) NOT NULL,
  `kd_kayu` varchar(10) DEFAULT NULL,
  `ID_mitra` varchar(10) DEFAULT NULL,
  `tanggal_closing` date NOT NULL,
  `jumlah_barang_closing` int(11) NOT NULL,
  `nilai_closing` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `barang_closing`
--

INSERT INTO `barang_closing` (`ID_closing`, `kd_kayu`, `ID_mitra`, `tanggal_closing`, `jumlah_barang_closing`, `nilai_closing`) VALUES
('CLS01', 'KRL-005', 'MTR018', '2024-12-10', 12, 4725000),
('CLS02', 'KLR-008', 'MTR022', '2025-12-18', 10, 3937500);

-- --------------------------------------------------------

--
-- Table structure for table `barang_masuk`
--

CREATE TABLE `barang_masuk` (
  `ID_receiving` varchar(10) NOT NULL,
  `kd_kayu` varchar(10) NOT NULL,
  `ID_supplier` varchar(10) NOT NULL,
  `tanggal_receiving` date NOT NULL,
  `jumlah_barang_receiving` int(11) NOT NULL,
  `nilai_receiving` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `barang_masuk`
--

INSERT INTO `barang_masuk` (`ID_receiving`, `kd_kayu`, `ID_supplier`, `tanggal_receiving`, `jumlah_barang_receiving`, `nilai_receiving`) VALUES
('RCV001', 'KLR-003', 'SUP021', '2024-12-01', 10, 5512500.00),
('RCV002', 'KLR-004', 'SUP007', '2024-12-02', 20, 9000000.00),
('RCV003', 'KLR-005', 'SUP013', '2024-12-03', 15, 5625000.00),
('RCV004', 'KLR-006', 'SUP019', '2024-12-04', 10, 4500000.00),
('RCV005', 'KLR-007', 'SUP005', '2024-12-05', 8, 4200000.00),
('RCV006', 'KLR-008', 'SUP017', '2024-12-06', 25, 9375000.00),
('RCV007', 'KLR-009', 'SUP011', '2024-12-07', 30, 10800000.00),
('RCV008', 'KLR-010', 'SUP014', '2024-12-08', 15, 6750000.00),
('RCV009', 'KLR-011', 'SUP001', '2024-12-09', 10, 6000000.00),
('RCV010', 'KLR1', 'SUP022', '2024-12-10', 20, 3600000.00),
('RCV011', 'KLR2', 'SUP030', '2024-12-11', 15, 9750000.00),
('RCV012', 'KRL-004', 'SUP018', '2024-12-12', 25, 3500000.00),
('RCV013', 'KRL-005', 'SUP008', '2024-12-13', 10, 1800000.00),
('RCV014', 'KRL-006', 'SUP002', '2024-12-14', 20, 3000000.00),
('RCV015', 'KRL-007', 'SUP026', '2024-12-15', 15, 2700000.00),
('RCV016', 'KRL-008', 'SUP015', '2024-12-16', 25, 3750000.00),
('RCV017', 'KRL-009', 'SUP010', '2024-12-17', 35, 5775000.00),
('RCV018', 'KRL-010', 'SUP029', '2024-12-18', 30, 4050000.00),
('RCV019', 'KRL-011', 'SUP006', '2024-12-19', 40, 5200000.00),
('RCV020', 'KRL-012', 'SUP012', '2024-12-20', 35, 4200000.00),
('RCV021', 'KRL-013', 'SUP020', '2024-12-21', 25, 5625000.00),
('RCV022', 'KRL1', 'SUP009', '2024-12-22', 50, 3650000.00),
('RCV023', 'KRL2', 'SUP003', '2024-12-23', 30, 2400000.00),
('RCV024', 'KRL3', 'SUP016', '2024-12-24', 25, 2125000.00),
('RCV025', 'KRN-001', 'SUP023', '2024-12-25', 25, 4725000.00),
('RCV026', 'KRN-002', 'SUP004', '2024-12-26', 20, 3000000.00),
('RCV027', 'KRN-003', 'SUP028', '2024-12-27', 15, 1800000.00),
('RCV028', 'KRN-004', 'SUP024', '2024-12-28', 15, 1650000.00),
('RCV029', 'KRN-005', 'SUP013', '2024-12-29', 20, 1900000.00),
('RCV030', 'KRN-006', 'SUP022', '2024-12-30', 15, 2400000.00),
('RCV031', 'KRN-007', 'SUP021', '2024-12-31', 20, 2800000.00),
('RCV032', 'KRN-008', 'SUP027', '2024-12-01', 30, 2700000.00),
('RCV033', 'KRN-009', 'SUP025', '2024-12-02', 40, 5400000.00),
('RCV034', 'KRN-010', 'SUP026', '2024-12-03', 50, 3000000.00),
('RCV035', 'KRT-001', 'SUP029', '2024-12-04', 5, 3750000.00),
('RCV036', 'KRT-002', 'SUP030', '2024-12-05', 20, 6000000.00),
('RCV037', 'KRT-003', 'SUP019', '2024-12-06', 10, 9000000.00),
('RCV038', 'KRT-004', 'SUP018', '2024-12-07', 25, 4500000.00),
('RCV039', 'KRT-005', 'SUP017', '2024-12-08', 20, 5000000.00),
('RCV040', 'KRT-006', 'SUP016', '2024-12-09', 8, 7200000.00),
('RCV041', 'KRT-007', 'SUP015', '2024-12-10', 15, 4500000.00),
('RCV042', 'KRT-008', 'SUP014', '2024-12-11', 30, 4050000.00),
('RCV043', 'KRT-009', 'SUP013', '2024-12-12', 25, 5620000.00),
('RCV044', 'KRT-010', 'SUP012', '2024-12-13', 30, 8550000.00),
('RCV045', 'KRT-011', 'SUP011', '2024-12-14', 5, 3750000.00),
('RCV046', 'KRT-012', 'SUP010', '2024-12-15', 20, 4725000.00),
('RCV047', 'KRT-013', 'SUP009', '2024-12-16', 30, 3780000.00),
('RCV048', 'KRT-014', 'SUP008', '2024-12-17', 15, 3150000.00),
('RCV049', 'KRT-015', 'SUP007', '2024-12-18', 25, 5250000.00),
('RCV050', 'KRT-016', 'SUP006', '2024-12-19', 8, 7200000.00);

-- --------------------------------------------------------

--
-- Table structure for table `gudang`
--

CREATE TABLE `gudang` (
  `kd_gd` varchar(2) NOT NULL,
  `nm_gd` varchar(25) NOT NULL,
  `jenis` char(1) NOT NULL COMMENT '0=pokok, 1=pengecer, 2=distributor'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `kategori`
--

CREATE TABLE `kategori` (
  `kd_kat` varchar(15) NOT NULL,
  `nm_kat` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kategori`
--

INSERT INTO `kategori` (`kd_kat`, `nm_kat`) VALUES
('KAY1811240901', 'Kayu Ringan/ olahan'),
('KAY1811240928', 'Kayu Lunak'),
('KAY1811240933', 'Kayu Keras'),
('KAY1811240959', 'Kayu Tropis');

-- --------------------------------------------------------

--
-- Table structure for table `kayu`
--

CREATE TABLE `kayu` (
  `kd_kayu` varchar(15) NOT NULL,
  `nm_kayu` varchar(25) NOT NULL,
  `kd_kat` varchar(15) NOT NULL,
  `deskripsi` varchar(255) NOT NULL,
  `harga_beli` double NOT NULL,
  `harga_pokok` double NOT NULL,
  `harga_jual` double NOT NULL,
  `stok` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kayu`
--

INSERT INTO `kayu` (`kd_kayu`, `nm_kayu`, `kd_kat`, `deskripsi`, `harga_beli`, `harga_pokok`, `harga_jual`, `stok`) VALUES
('KAY13', 'bolean', 'KAY1811240933', 'cocok untuk membuat meja', 75000, 70000, 88000, 100),
('KLR-003', 'Sonokeling', 'KAY1811240933', 'Berwarna gelap, digunakan untuk instrumen musik.', 525000, 350000, 551250, 100),
('KLR-004', 'Acacia', 'KAY1811240933', 'Serbaguna dan tahan lama, cocok untuk furnitur tahan air.', 450000, 300000, 472500, 200),
('KLR-005', 'Maple', 'KAY1811240933', 'Kayu yang sangat halus, populer untuk furnitur mewah.', 375000, 250000, 393750, 150),
('KLR-006', 'Oak', 'KAY1811240933', 'Tahan lama dan kuat, sering digunakan untuk lantai kayu.', 450000, 300000, 472500, 150),
('KLR-007', 'Walnut', 'KAY1811240933', 'Elegan dengan warna gelap, cocok untuk furnitur premium.', 525000, 350000, 551250, 100),
('KLR-008', 'Beech', 'KAY1811240933', 'Kayu keras serbaguna, sering digunakan untuk parket.', 375000, 250000, 393750, 200),
('KLR-009', 'Birch', 'KAY1811240933', 'Tahan lama dengan warna terang, cocok untuk kabinet.', 360000, 240000, 378000, 250),
('KLR-010', 'Teak Plantation', 'KAY1811240933', 'Kayu jati dari hutan tanaman, kualitas lebih rendah.', 450000, 300000, 472500, 150),
('KLR-011', 'Cherry', 'KAY1811240933', 'Berwarna merah muda alami, populer untuk perabot mewah.', 600000, 400000, 630000, 100),
('KLR1', 'Meranti Merah', 'KAY1811240933', 'Kayu tropis, cocok untuk konstruksi dan furnitur.', 180000, 165000, 200000, 200),
('KLR2', 'Jati', 'KAY1811240933', 'Sangat tahan lama, sering dipakai untuk furnitur mewah.', 650000, 620000, 720000, 150),
('KRL-004', 'Alder', 'KAY1811240928', 'Kayu ringan dengan tekstur halus, cocok untuk alat musik.', 140000, 90000, 147000, 400),
('KRL-005', 'Redwood', 'KAY1811240928', 'Kayu tahan lama, sering digunakan untuk decking luar ruangan.', 180000, 120000, 189000, 150),
('KRL-006', 'Spruce', 'KAY1811240928', 'Digunakan untuk pembuatan gitar dan alat musik lainnya.', 150000, 100000, 157500, 200),
('KRL-007', 'Hemlock', 'KAY1811240928', 'Cocok untuk framing rumah, ringan dan ekonomis.', 180000, 120000, 189000, 150),
('KRL-008', 'Fir', 'KAY1811240928', 'Kayu ringan dan tahan lama, sering digunakan untuk konstruksi.', 150000, 100000, 157500, 400),
('KRL-009', 'Cypress', 'KAY1811240928', 'Aromatik dan tahan serangga, cocok untuk outdoor.', 165000, 110000, 173250, 350),
('KRL-010', 'Aspen', 'KAY1811240928', 'Ringan dan mudah dibentuk, cocok untuk furnitur sederhana.', 135000, 90000, 141750, 300),
('KRL-011', 'Poplar', 'KAY1811240928', 'Tekstur halus, digunakan untuk plywood dan furnitur.', 130000, 85000, 136500, 400),
('KRL-012', 'Willow', 'KAY1811240928', 'Kayu ringan, digunakan untuk kerajinan tangan.', 120000, 80000, 126000, 350),
('KRL-013', 'Douglas Fir', 'KAY1811240928', 'Kayu konstruksi tahan lama dengan warna kemerahan.', 225000, 150000, 236250, 250),
('KRL1', 'Balsa', 'KAY1811240928', 'Kayu ringan dan mudah dibentuk, sering dipakai untuk model.', 73000, 70000, 78750, 500),
('KRL2', 'Pinus', 'KAY1811240928', 'Kayu dengan tekstur halus, cocok untuk furnitur dan dekorasi.', 80000, 75000, 94000, 300),
('KRL3', 'Cedar', 'KAY1811240928', 'Aromatik, tahan lama, dan sering digunakan untuk lemari.', 85000, 80000, 95800, 250),
('KRN-001', 'MDF', 'KAY1811240901', 'Medium-density fiberboard, digunakan untuk furnitur.', 180000, 120000, 189000, 250),
('KRN-002', 'Plywood', 'KAY1811240901', 'Kayu lapis serbaguna untuk konstruksi.', 150000, 100000, 157500, 300),
('KRN-003', 'Laminated Board', 'KAY1811240901', 'Kayu olahan dengan lapisan tahan air.', 120000, 90000, 126000, 200),
('KRN-004', 'Blockboard', 'KAY1811240901', 'Kayu olahan untuk pintu dan furnitur sederhana.', 110000, 70000, 115500, 200),
('KRN-005', 'Particle Board', 'KAY1811240901', 'Kayu serbuk dengan harga ekonomis, cocok untuk rak.', 95000, 60000, 99750, 350),
('KRN-006', 'HDF', 'KAY1811240901', 'High-density fiberboard, lebih kuat dari MDF.', 160000, 120000, 168000, 150),
('KRN-007', 'WPC', 'KAY1811240901', 'Wood-plastic composite, tahan air dan cuaca.', 180000, 140000, 189000, 250),
('KRN-008', 'OSB', 'KAY1811240901', 'Oriented strand board, digunakan untuk konstruksi.', 120000, 90000, 126000, 300),
('KRN-009', 'Veneer', 'KAY1811240901', 'Lapisan kayu tipis untuk dekorasi mewah.', 135000, 100000, 141750, 400),
('KRN-010', 'LDF', 'KAY1811240901', 'Low-density fiberboard, ekonomis untuk rak ringan.', 80000, 60000, 84000, 500),
('KRT-001', 'Ebony', 'KAY1811240959', 'Gelap dan eksotis, sering digunakan untuk ukiran.', 750000, 500000, 787500, 50),
('KRT-002', 'Mahoni', 'KAY1811240959', 'Tahan lama dan mudah dibentuk, cocok untuk furnitur.', 300000, 200000, 315000, 200),
('KRT-003', 'Ulin', 'KAY1811240959', 'Sangat keras, sering digunakan untuk struktur rumah.', 900000, 600000, 945000, 50),
('KRT-004', 'Kamper', 'KAY1811240959', 'Serbaguna dan tahan lama, digunakan untuk konstruksi.', 180000, 120000, 189000, 300),
('KRT-005', 'Bangkirai', 'KAY1811240959', 'Sangat kuat dan tahan cuaca, sering digunakan decking.', 375000, 250000, 393750, 200),
('KRT-006', 'Cendana', 'KAY1811240959', 'Beraroma khas, digunakan untuk kerajinan dan parfum.', 900000, 600000, 945000, 80),
('KRT-007', 'Merbau', 'KAY1811240959', 'Sangat keras, populer untuk lantai dan jembatan.', 450000, 300000, 472500, 150),
('KRT-008', 'Damar Laut', 'KAY1811240959', 'Ringan, sering digunakan untuk perabot sederhana.', 135000, 90000, 141750, 300),
('KRT-009', 'Ramin', 'KAY1811240959', 'Berwarna terang, sering digunakan untuk bingkai pintu.', 225000, 150000, 236250, 250),
('KRT-010', 'Sungkai', 'KAY1811240959', 'Tekstur menarik, digunakan untuk furnitur dan lantai.', 283500, 180000, 283500, 300),
('KRT-011', 'Kayu Besi', 'KAY1811240959', 'Sangat keras dan tahan lama, sering digunakan untuk kapal.', 750000, 500000, 787500, 50),
('KRT-012', 'Kelapa', 'KAY1811240959', 'Kayu eksotis, cocok untuk dekorasi tradisional.', 236250, 150000, 236250, 200),
('KRT-013', 'Gelam', 'KAY1811240959', 'Kayu lokal untuk konstruksi ringan.', 126000, 80000, 126000, 300),
('KRT-014', 'Kruing', 'KAY1811240959', 'Kuat dan tahan lama, sering digunakan untuk jembatan.', 315000, 200000, 315000, 150),
('KRT-015', 'Kayu Manis', 'KAY1811240959', 'Digunakan untuk kerajinan tangan dan hiasan.', 200000, 140000, 210000, 250),
('KRT-016', 'Kayu Gaharu', 'KAY1811240959', 'Kayu wangi untuk parfum dan dekorasi.', 900000, 600000, 945000, 80),
('KRT-017', 'Kayu Kopi', 'KAY1811240959', 'Kayu keras dari pohon kopi, unik dan eksotis.', 300000, 200000, 315000, 150),
('KRT-018', 'Kayu Nangka', 'KAY1811240959', 'Digunakan untuk alat musik tradisional.', 225000, 150000, 236250, 200),
('KRT-019', 'Kayu Sengon', 'KAY1811240959', 'Kayu ringan untuk konstruksi sederhana.', 120000, 85000, 126000, 400),
('KRT-020', 'Kayu Waru', 'KAY1811240959', 'Kayu lokal untuk furnitur kecil.', 95000, 70000, 99750, 300),
('KRT-021', 'Kayu Tanjung', 'KAY1811240959', 'Tahan lama untuk jembatan kecil.', 300000, 200000, 315000, 250),
('KRT-022', 'Kayu Salam', 'KAY1811240959', 'Kayu beraroma untuk ukiran.', 450000, 300000, 472500, 100),
('KRT-023', 'Kayu Randu', 'KAY1811240959', 'Kayu ringan untuk dekorasi.', 100000, 70000, 105000, 350),
('KRT-024', 'Kayu Jabon buana', 'KAY1811240959', 'Kayu cepat tumbuh dan tahan lama untuk bahan industri.', 150000, 100000, 157500, 500);

-- --------------------------------------------------------

--
-- Table structure for table `mitra`
--

CREATE TABLE `mitra` (
  `ID_mitra` varchar(10) NOT NULL,
  `nama_mitra` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `mitra`
--

INSERT INTO `mitra` (`ID_mitra`, `nama_mitra`) VALUES
('MTR001', 'Meubel Jaya Bandung'),
('MTR002', 'Furniture Classic Jogja'),
('MTR003', 'Kayu Asri Surabaya'),
('MTR004', 'Interior Minimalis Jakarta'),
('MTR005', 'Mega Jati Bali'),
('MTR006', 'Elegan Mebel Solo'),
('MTR007', 'Modern Furniture Malang'),
('MTR008', 'Sentra Furnish Medan'),
('MTR009', 'Mitra Utama Semarang'),
('MTR010', 'Central Kayu Aceh'),
('MTR011', 'FurniArt Depok'),
('MTR012', 'Luxury Interior Bogor'),
('MTR013', 'Creative Wood Palembang'),
('MTR014', 'Classic Room Padang'),
('MTR015', 'Jepara Craft Yogyakarta'),
('MTR016', 'Fine Wood Tangerang'),
('MTR017', 'Raja Interior Bekasi'),
('MTR018', 'Solid Furnish Banjarmasin'),
('MTR019', 'Top Furniture Pontianak'),
('MTR020', 'Inspirasi Interior Samarinda'),
('MTR021', 'Mega Wood Balikpapan'),
('MTR022', 'Artistic Home Tasikmalaya'),
('MTR023', 'Furnico Lampung'),
('MTR024', 'Jati Asli Banyuwangi'),
('MTR025', 'Simple Style Makassar');

-- --------------------------------------------------------

--
-- Stand-in structure for view `sisastok`
-- (See below for the actual view)
--
CREATE TABLE `sisastok` (
`kode_kayu` varchar(15)
,`nama_kayu` varchar(25)
,`jumlah_masuk` decimal(32,0)
,`stok_awal` int(11)
,`jumlah_keluar` decimal(32,0)
,`sisa_stok` decimal(34,0)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `sisa_stok`
-- (See below for the actual view)
--
CREATE TABLE `sisa_stok` (
`kode_kayu` varchar(15)
,`nama_kayu` varchar(25)
,`jumlah_masuk` decimal(32,0)
,`stok_awal` decimal(33,0)
,`jumlah_keluar` decimal(32,0)
,`sisa_stok` decimal(34,0)
);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `ID_supplier` varchar(10) NOT NULL,
  `nama_supplier` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`ID_supplier`, `nama_supplier`) VALUES
('SUP001', 'Meuble Adi Buana'),
('SUP002', 'Kayu Jaya Makmur'),
('SUP003', 'Supplier Cahaya Timur'),
('SUP004', 'Mega Kayu Perkasa'),
('SUP005', 'Sentosa Woodcraft'),
('SUP006', 'Lestari Kayu Mulia Sejati'),
('SUP007', 'Surya Utama Wood'),
('SUP008', 'Makmur Jaya Abadi'),
('SUP009', 'Kayu Indah Lestari'),
('SUP010', 'Bumi Kayu Sentosa'),
('SUP011', 'Prima Kayu Nusantara'),
('SUP012', 'Harapan Mulia Supplier'),
('SUP013', 'Kayu Abadi Sejahtera'),
('SUP014', 'Rimba Raya Wood'),
('SUP015', 'Gunung Mas Kayu'),
('SUP016', 'Kayu Nusantara Jaya'),
('SUP017', 'Sumber Kayu Alami'),
('SUP018', 'Hutan Lestari Sejahtera'),
('SUP019', 'Agro Kayu Perkasa'),
('SUP020', 'Eka Jaya Woodcraft'),
('SUP021', 'Pionir Kayu Sentosa'),
('SUP022', 'Trijaya Supplier Kayu'),
('SUP023', 'Kayu Bersama Makmur'),
('SUP024', 'Bahari Kayu Indah'),
('SUP025', 'Sejahtera Wood Supplies'),
('SUP026', 'Kayu Makmur Bersaudara'),
('SUP027', 'Supplier Kayu Nusantara'),
('SUP028', 'Multi Kayu Utama'),
('SUP029', 'Kayu Harmoni Perkasa'),
('SUP030', 'Lestari Kayu Abadi'),
('SUP035', 'Bima nata');

-- --------------------------------------------------------

--
-- Stand-in structure for view `view_sisa_stok`
-- (See below for the actual view)
--
CREATE TABLE `view_sisa_stok` (
`kd_kayu` varchar(15)
,`nm_kayu` varchar(25)
,`stok_awal` int(11)
,`total_terjual` decimal(32,0)
,`sisa_stok` decimal(33,0)
);

-- --------------------------------------------------------

--
-- Structure for view `sisastok`
--
DROP TABLE IF EXISTS `sisastok`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `sisastok`  AS SELECT `k`.`kd_kayu` AS `kode_kayu`, `k`.`nm_kayu` AS `nama_kayu`, ifnull(sum(`bm`.`jumlah_barang_receiving`),0) AS `jumlah_masuk`, `k`.`stok` AS `stok_awal`, ifnull(sum(`bc`.`jumlah_barang_closing`),0) AS `jumlah_keluar`, `k`.`stok`+ ifnull(sum(`bm`.`jumlah_barang_receiving`),0) - ifnull(sum(`bc`.`jumlah_barang_closing`),0) AS `sisa_stok` FROM ((`kayu` `k` left join `barang_masuk` `bm` on(`k`.`kd_kayu` = `bm`.`kd_kayu`)) left join `barang_closing` `bc` on(`k`.`kd_kayu` = `bc`.`kd_kayu`)) GROUP BY `k`.`kd_kayu`, `k`.`nm_kayu`, `k`.`stok` ;

-- --------------------------------------------------------

--
-- Structure for view `sisa_stok`
--
DROP TABLE IF EXISTS `sisa_stok`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `sisa_stok`  AS SELECT `k`.`kd_kayu` AS `kode_kayu`, `k`.`nm_kayu` AS `nama_kayu`, ifnull(sum(`bm`.`jumlah_barang_receiving`),0) AS `jumlah_masuk`, `k`.`stok`+ ifnull(sum(`bm`.`jumlah_barang_receiving`),0) AS `stok_awal`, ifnull(sum(`bc`.`jumlah_barang_closing`),0) AS `jumlah_keluar`, `k`.`stok`+ ifnull(sum(`bm`.`jumlah_barang_receiving`),0) - ifnull(sum(`bc`.`jumlah_barang_closing`),0) AS `sisa_stok` FROM ((`kayu` `k` left join `barang_masuk` `bm` on(`k`.`kd_kayu` = `bm`.`kd_kayu`)) left join `barang_closing` `bc` on(`k`.`kd_kayu` = `bc`.`kd_kayu`)) GROUP BY `k`.`kd_kayu`, `k`.`nm_kayu`, `k`.`stok` ;

-- --------------------------------------------------------

--
-- Structure for view `view_sisa_stok`
--
DROP TABLE IF EXISTS `view_sisa_stok`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_sisa_stok`  AS SELECT `k`.`kd_kayu` AS `kd_kayu`, `k`.`nm_kayu` AS `nm_kayu`, `k`.`stok` AS `stok_awal`, ifnull(sum(`bc`.`jumlah_barang_closing`),0) AS `total_terjual`, `k`.`stok`- ifnull(sum(`bc`.`jumlah_barang_closing`),0) AS `sisa_stok` FROM (`kayu` `k` left join `barang_closing` `bc` on(`k`.`kd_kayu` = `bc`.`kd_kayu`)) GROUP BY `k`.`kd_kayu`, `k`.`nm_kayu`, `k`.`stok` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`kd_admin`);

--
-- Indexes for table `barang_closing`
--
ALTER TABLE `barang_closing`
  ADD PRIMARY KEY (`ID_closing`),
  ADD KEY `kd_kayu` (`kd_kayu`),
  ADD KEY `ID_mitra` (`ID_mitra`);

--
-- Indexes for table `barang_masuk`
--
ALTER TABLE `barang_masuk`
  ADD PRIMARY KEY (`ID_receiving`),
  ADD KEY `kd_kayu` (`kd_kayu`),
  ADD KEY `ID_supplier` (`ID_supplier`);

--
-- Indexes for table `gudang`
--
ALTER TABLE `gudang`
  ADD PRIMARY KEY (`kd_gd`);

--
-- Indexes for table `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`kd_kat`);

--
-- Indexes for table `kayu`
--
ALTER TABLE `kayu`
  ADD PRIMARY KEY (`kd_kayu`),
  ADD KEY `kd_kat` (`kd_kat`);

--
-- Indexes for table `mitra`
--
ALTER TABLE `mitra`
  ADD PRIMARY KEY (`ID_mitra`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID_supplier`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `barang_closing`
--
ALTER TABLE `barang_closing`
  ADD CONSTRAINT `barang_closing_ibfk_1` FOREIGN KEY (`kd_kayu`) REFERENCES `kayu` (`kd_kayu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `barang_closing_ibfk_2` FOREIGN KEY (`ID_mitra`) REFERENCES `mitra` (`ID_mitra`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `barang_masuk`
--
ALTER TABLE `barang_masuk`
  ADD CONSTRAINT `barang_masuk_ibfk_1` FOREIGN KEY (`kd_kayu`) REFERENCES `kayu` (`kd_kayu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `barang_masuk_ibfk_2` FOREIGN KEY (`ID_supplier`) REFERENCES `supplier` (`ID_supplier`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `kayu`
--
ALTER TABLE `kayu`
  ADD CONSTRAINT `kayu_ibfk_1` FOREIGN KEY (`kd_kat`) REFERENCES `kategori` (`kd_kat`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
