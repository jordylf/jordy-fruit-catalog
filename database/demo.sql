-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2024 at 09:10 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_tokojordy26624`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_member`
--

CREATE TABLE `tbl_member` (
  `idMember` int(11) NOT NULL,
  `kodeMember` varchar(80) NOT NULL,
  `tglDaftar` date NOT NULL,
  `namaMember` varchar(40) NOT NULL,
  `alamat` text NOT NULL,
  `level` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `noTelp` varchar(20) NOT NULL,
  `status` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_member`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `idpelanggan` int(7) NOT NULL,
  `kodePelanggan` varchar(30) NOT NULL,
  `tglBuat` datetime NOT NULL,
  `namaPelanggan` varchar(40) NOT NULL,
  `notelp` varchar(20) NOT NULL,
  `kodeMember` varchar(40) NOT NULL,
  `hargaTotal` int(9) NOT NULL,
  `jenisPembayaran` varchar(30) NOT NULL,
  `noHPPayment` varchar(20) NOT NULL,
  `kembalian` int(9) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pelanggan`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_pengguna`
--

CREATE TABLE `tbl_pengguna` (
  `idPengguna` int(7) NOT NULL,
  `namaLengkap` varchar(40) NOT NULL,
  `jenisKelamin` varchar(20) NOT NULL,
  `tglLahir` date NOT NULL,
  `noTelp` varchar(20) NOT NULL,
  `namaPengguna` varchar(40) NOT NULL,
  `kataSandi` varchar(40) NOT NULL,
  `role` varchar(30) NOT NULL,
  `status` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pengguna`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_pesanan`
--

CREATE TABLE `tbl_pesanan` (
  `idpesanan` int(7) NOT NULL,
  `tglPesan` datetime NOT NULL,
  `kodeProduk` varchar(30) NOT NULL,
  `namaProduk` varchar(40) NOT NULL,
  `harga` int(7) NOT NULL,
  `idpelanggan` int(7) NOT NULL,
  `kodePesanan` varchar(30) NOT NULL,
  `jumlah` int(4) NOT NULL,
  `hargaTotal` int(9) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pesanan`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_produk`
--

CREATE TABLE `tbl_produk` (
  `idProduk` int(7) NOT NULL,
  `kodeProduk` varchar(30) NOT NULL,
  `namaBuah` varchar(40) NOT NULL,
  `satuan` varchar(30) NOT NULL,
  `kualitas` varchar(40) NOT NULL,
  `harga` int(7) NOT NULL,
  `namaFile` text NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_produk`
--

INSERT INTO `tbl_produk` (`idProduk`, `kodeProduk`, `namaBuah`, `satuan`, `kualitas`, `harga`, `namaFile`, `keterangan`) VALUES
(1, 'kg0001', 'buah apel malang', 'PCS', 'TERBAIK', 7000, 'img-30062024080910.png', 'baru masuk');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_member`
--
ALTER TABLE `tbl_member`
  ADD PRIMARY KEY (`idMember`);

--
-- Indexes for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`idpelanggan`);

--
-- Indexes for table `tbl_pengguna`
--
ALTER TABLE `tbl_pengguna`
  ADD PRIMARY KEY (`idPengguna`);

--
-- Indexes for table `tbl_pesanan`
--
ALTER TABLE `tbl_pesanan`
  ADD PRIMARY KEY (`idpesanan`);

--
-- Indexes for table `tbl_produk`
--
ALTER TABLE `tbl_produk`
  ADD PRIMARY KEY (`idProduk`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_member`
--
ALTER TABLE `tbl_member`
  MODIFY `idMember` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  MODIFY `idpelanggan` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_pengguna`
--
ALTER TABLE `tbl_pengguna`
  MODIFY `idPengguna` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_pesanan`
--
ALTER TABLE `tbl_pesanan`
  MODIFY `idpesanan` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_produk`
--
ALTER TABLE `tbl_produk`
  MODIFY `idProduk` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

-- Akun fiktif untuk demo lokal, bukan kredensial produksi.
INSERT INTO `tbl_pengguna` (`idPengguna`, `namaLengkap`, `jenisKelamin`, `tglLahir`, `noTelp`, `namaPengguna`, `kataSandi`, `role`, `status`) VALUES
(1, 'Administrator Demo', 'Laki-Laki', '2000-01-01', '', 'admin', '1234', 'Administrator', '1');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

