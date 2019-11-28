-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 28. 11 2019 kl. 10:57:31
-- Serverversion: 10.3.16-MariaDB
-- PHP-version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testdb`
--

DELIMITER $$
--
-- Procedurer
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_order` (IN `orderID` INT(11))  BEGIN

DELETE FROM orders WHERE Order_ID=orderID;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `addresses`
--

CREATE TABLE `addresses` (
  `ADDR_ID` int(11) NOT NULL,
  `User_ID` int(11) NOT NULL,
  `Address` varchar(256) NOT NULL,
  `City` varchar(256) NOT NULL,
  `Zip_Code` int(11) NOT NULL,
  `Country` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `addresses`
--

INSERT INTO `addresses` (`ADDR_ID`, `User_ID`, `Address`, `City`, `Zip_Code`, `Country`) VALUES
(4, 1, 'Address1', 'City1', 9846, 'Denmark'),
(5, 2, 'Address2', 'City2', 1199, 'England'),
(6, 3, 'Address3', 'City3', 9464, 'The Moon'),
(7, 4, 'Address4', 'City4', 8946, 'China'),
(8, 5, 'Address5', 'City5', 1325, 'The Son'),
(9, 6, 'Address6', 'City6', 4668, 'On Earth'),
(10, 7, 'Address7', 'City7', 1894, 'Autaralia'),
(11, 8, 'Address8', 'City8', 6484, 'The Underworld'),
(12, 9, 'Address9', 'City9', 4894, 'The End'),
(13, 10, 'Address10', 'City10', 4896, 'Nether');

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `name_and_addresses`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `name_and_addresses` (
`ID` int(11)
,`Username` varchar(256)
,`First_Name` varchar(256)
,`Last_Name` varchar(256)
,`Address` varchar(256)
,`City` varchar(256)
,`Zip_Code` int(11)
,`Country` varchar(256)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `orders`
--

CREATE TABLE `orders` (
  `Order_ID` int(11) NOT NULL,
  `Prod_ID` int(11) NOT NULL,
  `User_ID` int(11) NOT NULL,
  `ADDR_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `orders`
--

INSERT INTO `orders` (`Order_ID`, `Prod_ID`, `User_ID`, `ADDR_ID`) VALUES
(2, 4, 9, 4),
(3, 10, 1, 4),
(4, 9, 7, 10),
(5, 5, 5, 8);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `products`
--

CREATE TABLE `products` (
  `Prod_ID` int(11) NOT NULL,
  `Prod_Name` varchar(256) NOT NULL,
  `Prod_Description` varchar(256) DEFAULT NULL,
  `Prod_Stock` int(11) NOT NULL,
  `Prod_Prize` double(11,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `products`
--

INSERT INTO `products` (`Prod_ID`, `Prod_Name`, `Prod_Description`, `Prod_Stock`, `Prod_Prize`) VALUES
(1, 'Cheap car', 'This car is cheap as fuck', 11, 9999991.00),
(2, 'Cool car', 'This car is cool as fuck', 15, 999999.00),
(3, 'Pretty Car', 'This car is pretty as fuck', 2, 896.00),
(4, 'Your mom', 'You can buy your own mom back', 1, 25.00),
(5, 'Your dad', 'You can buy your own dad back', 1, 15.00),
(6, 'Personel info', 'Your can buy a fresh batch of personel information', 564655, 1250.00),
(7, 'Small child', 'You can get a small child', 1365, 6000.00),
(8, 'Big child', 'You can get a big child', 38464, 500.00),
(9, 'Girl Gamer Pee', 'You can get some girl gamer pee', 8796, 1000.00),
(10, 'Boy Gamer Pee', 'You can get some boy gamer pee', 789545, 25.00);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `products_view`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `products_view` (
`Prod_Name` varchar(256)
,`Prod_Stock` int(11)
,`Prod_Prize` double(11,2)
);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `testview`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `testview` (
`ID` int(11)
,`Username` varchar(256)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `Username` varchar(256) NOT NULL,
  `EMail` varchar(256) NOT NULL,
  `First_Name` varchar(256) NOT NULL,
  `Last_Name` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `users`
--

INSERT INTO `users` (`ID`, `Username`, `EMail`, `First_Name`, `Last_Name`) VALUES
(1, 'Per123', 'mail@mail.com', 'Per', 'Petersen'),
(2, 'Person1', 'mail@mail.com', 'First Name', 'Second Name'),
(3, 'Person2', 'mail@mail.com', 'First Name', 'Second Name'),
(4, 'Person3', 'mail@mail.com', 'First Name', 'Second Name'),
(5, 'Person4', 'mail@mail.com', 'First Name', 'Second Name'),
(6, 'Person5', 'mail@mail.com', 'First Name', 'Second Name'),
(7, 'Person6', 'mail@mail.com', 'First Name', 'Second Name'),
(8, 'Person7', 'mail@mail.com', 'First Name', 'Second Name'),
(9, 'Person8', 'mail@mail.com', 'First Name', 'Second Name'),
(10, 'Person9', 'mail@mail.com', 'First Name', 'Second Name');

-- --------------------------------------------------------

--
-- Struktur for visning `name_and_addresses`
--
DROP TABLE IF EXISTS `name_and_addresses`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `name_and_addresses`  AS  select `users`.`ID` AS `ID`,`users`.`Username` AS `Username`,`users`.`First_Name` AS `First_Name`,`users`.`Last_Name` AS `Last_Name`,`addresses`.`Address` AS `Address`,`addresses`.`City` AS `City`,`addresses`.`Zip_Code` AS `Zip_Code`,`addresses`.`Country` AS `Country` from (`users` join `addresses` on(`addresses`.`User_ID` = `users`.`ID`)) ;

-- --------------------------------------------------------

--
-- Struktur for visning `products_view`
--
DROP TABLE IF EXISTS `products_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `products_view`  AS  select `products`.`Prod_Name` AS `Prod_Name`,`products`.`Prod_Stock` AS `Prod_Stock`,`products`.`Prod_Prize` AS `Prod_Prize` from `products` ;

-- --------------------------------------------------------

--
-- Struktur for visning `testview`
--
DROP TABLE IF EXISTS `testview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `testview`  AS  select `users`.`ID` AS `ID`,`users`.`Username` AS `Username` from `users` ;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `addresses`
--
ALTER TABLE `addresses`
  ADD PRIMARY KEY (`ADDR_ID`),
  ADD KEY `User_ID` (`User_ID`);

--
-- Indeks for tabel `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`Order_ID`),
  ADD KEY `Prod_ID` (`Prod_ID`),
  ADD KEY `User_ID` (`User_ID`),
  ADD KEY `ADDR_ID` (`ADDR_ID`);

--
-- Indeks for tabel `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`Prod_ID`);

--
-- Indeks for tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `addresses`
--
ALTER TABLE `addresses`
  MODIFY `ADDR_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Tilføj AUTO_INCREMENT i tabel `orders`
--
ALTER TABLE `orders`
  MODIFY `Order_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tilføj AUTO_INCREMENT i tabel `products`
--
ALTER TABLE `products`
  MODIFY `Prod_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tilføj AUTO_INCREMENT i tabel `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `addresses`
--
ALTER TABLE `addresses`
  ADD CONSTRAINT `addresses_ibfk_1` FOREIGN KEY (`User_ID`) REFERENCES `users` (`ID`);

--
-- Begrænsninger for tabel `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`Prod_ID`) REFERENCES `products` (`Prod_ID`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`User_ID`) REFERENCES `users` (`ID`),
  ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`ADDR_ID`) REFERENCES `addresses` (`ADDR_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
