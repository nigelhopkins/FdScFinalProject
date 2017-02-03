-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 01, 2015 at 05:22 PM
-- Server version: 5.6.15-log
-- PHP Version: 5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `websitedevelopment`
--

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE IF NOT EXISTS `members` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` char(128) NOT NULL,
  `salt` char(128) NOT NULL,
  `CompanyName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `PhoneNumber` varchar(11) NOT NULL,
  `BuildingNumber` varchar(50) NOT NULL,
  `StreetName` varchar(50) NOT NULL,
  `City` varchar(50) NOT NULL,
  `County` varchar(50) NOT NULL,
  `PostalCode` varchar(50) NOT NULL,
  `pin` varchar(6) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=78 ;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`id`, `username`, `email`, `password`, `salt`, `CompanyName`, `FirstName`, `LastName`, `PhoneNumber`, `BuildingNumber`, `StreetName`, `City`, `County`, `PostalCode`, `pin`) VALUES
(77, 'nigel.hopkins@hotmail.co.uk', 'nigel.hopkins@hotmail.co.uk', '577a7adbe245a2dc1445279f60ecb6f75b3db9b1d44039611b779b2d19312db1585c83353a02c462eaa350262656bd4296142ef98e74a07128aa8ac254ea20bb', '6e12f4673ac0198bba83a382c43e0186c21e00123d978b5e66b1634216da293f5927fd645fb6f9276987ce799994eb4c25d9c273d0af47368e39d3fa36b2f095', 'NH Web Design', 'Nigel', 'Hopkins', '07828609117', '95', 'Bampflyde Way', 'Plymouth', 'Devon', 'PL66SS', '141733');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
