SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;


CREATE TABLE IF NOT EXISTS `login_attempts` (
  `user_id` int(11) NOT NULL,
  `time` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `login_attempts` (`user_id`, `time`) VALUES
(3, '1422701547'),
(3, '1422701564'),
(3, '1422701587'),
(3, '1422904914'),
(3, '1422904926'),
(3, '1422904938'),
(3, '1422904948'),
(2, '1423048445'),
(2, '1423135557'),
(2, '1423565162'),
(2, '1423565178'),
(2, '1423565328'),
(2, '1423565337'),
(2, '1423565707'),
(2, '1423565717'),
(3, '1423567614'),
(2, '1423576145'),
(7, '1424967192'),
(9, '1424967342'),
(2, '1424987964'),
(57, '1425071172'),
(77, '1425149290'),
(77, '1425149302'),
(77, '1425156149'),
(77, '1425156161'),
(77, '1425341075');

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

INSERT INTO `members` (`id`, `username`, `email`, `password`, `salt`, `CompanyName`, `FirstName`, `LastName`, `PhoneNumber`, `BuildingNumber`, `StreetName`, `City`, `County`, `PostalCode`, `pin`) VALUES
(77, 'nigel.hopkins@hotmail.co.uk', 'nigel.hopkins@hotmail.co.uk', '3932999741a9c84db350b6c2b15b03196650620970716a14853d58a7d3b1bd6e4a1d3c4b5ba942045872c6cb92838a450ee3dfd3b16070a8769a5cd19d04e888', 'fcabeae870b9c75027a551a9c7a529f645dad6ccfaaa4c7ee5377c9c4ca1e09b083655eb1a6bd7f91f3116a64d9867f65819bccaea181fcc7e241ebc7bde4db8', 'NH Web Design', 'Nigel', 'Hopkins', '07828609117', '95', 'Bampflyde Way', 'Plymouth', 'Devon', 'PL66SS', '');

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

INSERT INTO `products` (`id`, `product_code`, `product_name`, `product_desc`, `product_img_name`, `price`) VALUES
(81, 'PD005', 'Greenex', 'Free CSS website template from Metamorphosis Design', 'Greenex.jpg', '0.99'),
(80, 'PD004', 'Leather & Coffee', 'This 5 page template uses brown, cream, grey & white. Images are provided by http://fotogrph.com. This website template uses a jQuery image fader & contains CSS3 code.', 'Leather&Coffee.jpg', '0.99'),
(79, 'PD003', 'Plasma', 'This 5 page website template uses various shades of grey & white on an image background. Images are provided by http://fotogrph.com. It also uses a jQuery image slider & contains CSS3 code.', 'Plasma.jpg', '0.99'),
(78, 'PD002', 'Water', 'This 5 page template uses various shades of blue on an image background. This website template is written with html5 & CSS3 code, utilises @font-face and a jQuery image fader.', 'Water.jpg', '0.99'),
(77, 'PD001', 'Blue Skies', 'This 5 page website template uses blue, grey, & white on an image background. Images are provided by http://fotogrph.com. It also uses a jQuery image fader & contains CSS3 code.', 'BlueSkies.jpg', '0.99');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
