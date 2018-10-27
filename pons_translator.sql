-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 27, 2018 at 06:38 PM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pons_translator`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `id` int(50) NOT NULL,
  `name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `name`) VALUES
(2, 'Essen'),
(3, 'Sports'),
(4, 'Music');

-- --------------------------------------------------------

--
-- Table structure for table `word`
--

CREATE TABLE `word` (
  `id` int(50) NOT NULL,
  `categoryId` int(50) NOT NULL,
  `count` int(50) NOT NULL,
  `name` varchar(200) NOT NULL,
  `language` varchar(200) NOT NULL,
  `translation` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `word`
--

INSERT INTO `word` (`id`, `categoryId`, `count`, `name`, `language`, `translation`) VALUES
(1, 2, 0, 'Apfel', 'en', 'Apple'),
(2, 2, 0, 'Karote', 'en', 'Carrot'),
(3, 2, 0, 'Salat', 'en', 'Salad'),
(4, 3, 0, 'Fussball', 'en', 'Football'),
(5, 3, 0, 'Tanzen', 'en', 'To dance'),
(6, 3, 0, 'Rennen', 'en', 'to run'),
(7, 4, 0, 'Singen', 'en', 'to sing'),
(8, 4, 0, 'Guitarre', 'en', 'Guitar'),
(9, 4, 0, 'Schlagzeug', 'en', 'Drums');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `word`
--
ALTER TABLE `word`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `word`
--
ALTER TABLE `word`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
