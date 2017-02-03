-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 01, 2015 at 05:23 PM
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
-- Table structure for table `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product_code` varchar(60) NOT NULL,
  `product_name` varchar(60) NOT NULL,
  `product_desc` tinytext NOT NULL,
  `product_img_name` varchar(60) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `product_code` (`product_code`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=83 ;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`id`, `product_code`, `product_name`, `product_desc`, `product_img_name`, `price`) VALUES
(81, 'PD005', 'Greenex', 'Free CSS website template from Metamorphosis Design', 'Greenex.jpg', '0.99'),
(80, 'PD004', 'Leather & Coffee', 'This 5 page template uses brown, cream, grey & white. Images are provided by http://fotogrph.com. This website template uses a jQuery image fader & contains CSS3 code.', 'Leather&Coffee.jpg', '0.99'),
(79, 'PD003', 'Plasma', 'This 5 page website template uses various shades of grey & white on an image background. Images are provided by http://fotogrph.com. It also uses a jQuery image slider & contains CSS3 code.', 'Plasma.jpg', '0.99'),
(78, 'PD002', 'Water', 'This 5 page template uses various shades of blue on an image background. This website template is written with html5 & CSS3 code, utilises @font-face and a jQuery image fader.', 'Water.jpg', '0.99'),
(77, 'PD001', 'Blue Skies', 'This 5 page website template uses blue, grey, & white on an image background. Images are provided by http://fotogrph.com. It also uses a jQuery image fader & contains CSS3 code.', 'BlueSkies.jpg', '0.99');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
