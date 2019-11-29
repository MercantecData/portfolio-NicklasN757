-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 29. 11 2019 kl. 10:32:18
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
-- Database: `firmadb`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `department`
--

CREATE TABLE `department` (
  `ID` int(11) NOT NULL,
  `Specialization` varchar(256) COLLATE latin1_danish_ci NOT NULL,
  `Name` varchar(256) COLLATE latin1_danish_ci NOT NULL,
  `Country` varchar(256) COLLATE latin1_danish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_danish_ci;

--
-- Data dump for tabellen `department`
--

INSERT INTO `department` (`ID`, `Specialization`, `Name`, `Country`) VALUES
(1, 'Production', 'Robo Production', 'Denmark'),
(2, 'Software', 'Robo Software', 'Denmark'),
(3, 'Robotics', 'Robo Robotics', 'Germany'),
(4, 'Server', 'Robo Servers', 'Denmark'),
(5, 'HQ', 'Robo HQ', 'Denmark');

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_employee`
--

CREATE TABLE `dep_employee` (
  `ID` int(11) NOT NULL,
  `Emp_ID` int(11) NOT NULL,
  `Dep_ID` int(11) NOT NULL,
  `Sal_ID` int(11) NOT NULL,
  `Til_ID` int(11) NOT NULL,
  `Man_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_danish_ci;

--
-- Data dump for tabellen `dep_employee`
--

INSERT INTO `dep_employee` (`ID`, `Emp_ID`, `Dep_ID`, `Sal_ID`, `Til_ID`, `Man_ID`) VALUES
(1, 1, 1, 10, 10, 1),
(2, 2, 2, 10, 10, 2),
(3, 3, 3, 10, 10, 3),
(4, 4, 4, 10, 10, 4),
(5, 5, 5, 10, 10, 5),
(6, 6, 1, 14, 14, 1),
(7, 7, 1, 14, 14, 1),
(8, 8, 1, 14, 14, 1),
(9, 9, 1, 14, 14, 1),
(10, 10, 1, 14, 14, 1),
(11, 11, 1, 14, 14, 1),
(12, 12, 1, 14, 14, 1),
(13, 13, 1, 14, 14, 1),
(14, 14, 1, 14, 14, 1),
(16, 15, 2, 13, 13, 2),
(17, 16, 2, 13, 13, 2),
(18, 17, 2, 13, 13, 2),
(19, 18, 2, 13, 13, 2),
(20, 19, 2, 13, 13, 2),
(21, 20, 2, 13, 13, 2),
(22, 21, 2, 13, 13, 2),
(23, 22, 2, 13, 13, 2),
(24, 23, 2, 13, 13, 2),
(25, 24, 3, 13, 13, 3),
(26, 25, 3, 13, 13, 3),
(27, 26, 3, 13, 13, 3),
(28, 27, 3, 11, 11, 3),
(29, 28, 3, 11, 11, 3),
(30, 29, 3, 11, 11, 3),
(31, 30, 3, 15, 15, 3),
(32, 31, 3, 15, 15, 3),
(33, 32, 3, 16, 16, 3),
(34, 33, 4, 11, 11, 4),
(35, 34, 4, 11, 11, 4),
(36, 35, 4, 11, 11, 4),
(37, 36, 4, 11, 11, 4),
(38, 37, 4, 12, 12, 4),
(39, 38, 4, 12, 12, 4),
(40, 39, 4, 12, 12, 4),
(41, 40, 4, 16, 16, 4),
(42, 41, 4, 15, 15, 4),
(43, 42, 5, 1, 1, 5),
(44, 43, 5, 2, 2, 5),
(45, 44, 5, 3, 3, 5),
(46, 45, 5, 4, 4, 5),
(47, 46, 5, 5, 5, 5),
(48, 47, 5, 6, 6, 5),
(49, 48, 5, 7, 7, 5),
(50, 49, 5, 8, 8, 5),
(51, 50, 5, 9, 9, 5);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_manager`
--

CREATE TABLE `dep_manager` (
  `ID` int(11) NOT NULL,
  `Emp_ID` int(11) NOT NULL,
  `Dep_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_danish_ci;

--
-- Data dump for tabellen `dep_manager`
--

INSERT INTO `dep_manager` (`ID`, `Emp_ID`, `Dep_ID`) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `employee`
--

CREATE TABLE `employee` (
  `ID` int(11) NOT NULL,
  `First_Name` varchar(256) COLLATE latin1_danish_ci NOT NULL,
  `Last_Name` varchar(256) COLLATE latin1_danish_ci NOT NULL,
  `Mail` varchar(256) COLLATE latin1_danish_ci NOT NULL,
  `Phone_Number` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_danish_ci;

--
-- Data dump for tabellen `employee`
--

INSERT INTO `employee` (`ID`, `First_Name`, `Last_Name`, `Mail`, `Phone_Number`) VALUES
(1, 'Sandra', 'Henriksen', 'Sandra51073263@mail.com', 51073263),
(2, 'Nicklas', 'Markvart', 'Nicklas73567271@mail.com', 73567271),
(3, 'Sten', 'Grønne', 'Sten95222721@mail.com', 95222721),
(4, 'Layla', 'Hitler', 'Layla23930699@mail.com', 23930699),
(5, 'Pete', 'Groft', 'Pete39879999@mail.com', 39879999),
(6, 'Joe', 'Andersen', 'Joe48628224@mail.com', 48628224),
(7, 'Per', 'Robertson', 'Per62720136@mail.com', 62720136),
(8, 'Joe', 'Phillips', 'Joe55465997@mail.com', 55465997),
(9, 'Emma', 'Hudson', 'Emma33324425@mail.com', 33324425),
(10, 'Marcus', 'Jøregensen', 'Marcus56507542@mail.com', 56507542),
(11, 'Pete', 'Jacopsen', 'Pete56262638@mail.com', 56262638),
(12, 'Kasper', 'Henriksen', 'Kasper95776291@mail.com', 95776291),
(13, 'Emma', 'Jøregensen', 'Emma35452132@mail.com', 35452132),
(14, 'Emilie', 'Groft', 'Emilie78798395@mail.com', 78798395),
(15, 'Sten', 'Kjærgård', 'Sten69006020@mail.com', 69006020),
(16, 'Sandra', 'Jøregensen', 'Sandra49493812@mail.com', 49493812),
(17, 'Søren', 'Andersen', 'Søren35579412@mail.com', 35579412),
(18, 'Nick', 'Groft', 'Nick79591524@mail.com', 79591524),
(19, 'Layla', 'Palmer', 'Layla59640881@mail.com', 59640881),
(20, 'Kim', 'Kjærgård', 'Kim24595066@mail.com', 24595066),
(21, 'Marcus', 'Hitler', 'Marcus14829347@mail.com', 14829347),
(22, 'Marcus', 'Brooks', 'Marcus26988954@mail.com', 26988954),
(23, 'Marie', 'Groft', 'Marie60336400@mail.com', 60336400),
(24, 'Ole', 'Andersen', 'Ole26544539@mail.com', 26544539),
(25, 'Alex', 'Russell', 'Alex16416705@mail.com', 16416705),
(26, 'Rene', 'Jones', 'Rene39377713@mail.com', 39377713),
(27, 'Pia', 'Groft', 'Pia68029790@mail.com', 68029790),
(28, 'Rene', 'Markvart', 'Rene84983912@mail.com', 84983912),
(29, 'Mia', 'Markvart', 'Mia50167205@mail.com', 50167205),
(30, 'Layla', 'Sørensen', 'Layla66351602@mail.com', 66351602),
(31, 'Søren', 'Russell', 'Søren78628255@mail.com', 78628255),
(32, 'Per', 'Moris', 'Per44246625@mail.com', 44246625),
(33, 'Gabrielle', 'Hitler', 'Gabrielle85218609@mail.com', 85218609),
(34, 'Mikkel', 'Robertson', 'Mikkel38404965@mail.com', 38404965),
(35, 'Kristina', 'Nielsen', 'Kristina11278197@mail.com', 11278197),
(36, 'Per', 'Groft', 'Per39468715@mail.com', 39468715),
(37, 'Gabrielle', 'Jones', 'Gabrielle80839778@mail.com', 80839778),
(38, 'John', 'Moris', 'John61276261@mail.com', 61276261),
(39, 'Emma', 'Brooks', 'Emma54961304@mail.com', 54961304),
(40, 'John', 'Sten', 'John66995288@mail.com', 66995288),
(41, 'Layla', 'Groft', 'Layla53269947@mail.com', 53269947),
(42, 'Joe', 'Robertson', 'Joe84082780@mail.com', 84082780),
(43, 'Søren', 'Markvart', 'Søren52561229@mail.com', 52561229),
(44, 'Thea', 'Moris', 'Thea46575975@mail.com', 46575975),
(45, 'Mikkel', 'Henriksen', 'Mikkel94158766@mail.com', 94158766),
(46, 'Kasper', 'Jones', 'Kasper99173820@mail.com', 99173820),
(47, 'Rene', 'Petersen', 'Rene23831794@mail.com', 23831794),
(48, 'Per', 'Markvart', 'Per56593345@mail.com', 56593345),
(49, 'Pia', 'Sten', 'Pia53295561@mail.com', 53295561),
(50, 'Kasper', 'Robinson', 'Kasper52594684@mail.com', 52594684);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `salaries`
--

CREATE TABLE `salaries` (
  `ID` int(11) NOT NULL,
  `Tiltle_ID` int(11) NOT NULL,
  `Salaries` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_danish_ci;

--
-- Data dump for tabellen `salaries`
--

INSERT INTO `salaries` (`ID`, `Tiltle_ID`, `Salaries`) VALUES
(1, 1, 999999999),
(2, 2, 99999999),
(3, 3, 9999999),
(4, 4, 999999),
(5, 5, 75000),
(6, 6, 70000),
(7, 7, 60000),
(8, 8, 55000),
(9, 9, 50000),
(10, 10, 45000),
(11, 11, 35000),
(12, 12, 35000),
(13, 13, 35000),
(14, 14, 35000),
(15, 15, 25000),
(16, 16, 25000);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `titles`
--

CREATE TABLE `titles` (
  `ID` int(11) NOT NULL,
  `Name` varchar(256) COLLATE latin1_danish_ci NOT NULL,
  `Rank` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_danish_ci;

--
-- Data dump for tabellen `titles`
--

INSERT INTO `titles` (`ID`, `Name`, `Rank`) VALUES
(1, 'Chairman', 12),
(2, 'Chief Executive Officer (CEO)', 11),
(3, 'Chief Operations Officer (COO)', 10),
(4, 'Chief Financial Officer (CFO)', 9),
(5, 'Chief Administrative Officer (CAO)', 8),
(6, 'Chief Information Officer (CIO)', 7),
(7, 'Chief Technology Officer (CTO)', 6),
(8, 'Chief Marketing Officer (CMO)', 5),
(9, 'Chief Human Resources Officer (CHRO)', 4),
(10, 'Department Manager', 3),
(11, 'Data Technician', 2),
(12, 'Computer Technician-Infrastructure', 2),
(13, 'Computer Technician-Programming', 2),
(14, 'Production Worker', 2),
(15, 'IT Support', 1),
(16, 'Cleaning', 1);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`ID`);

--
-- Indeks for tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Emp_ID` (`Emp_ID`),
  ADD KEY `Dep_ID` (`Dep_ID`),
  ADD KEY `Sal_ID` (`Sal_ID`),
  ADD KEY `Til_ID` (`Til_ID`),
  ADD KEY `Man_ID` (`Man_ID`);

--
-- Indeks for tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Emp_ID` (`Emp_ID`),
  ADD KEY `Dep_ID` (`Dep_ID`);

--
-- Indeks for tabel `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`ID`);

--
-- Indeks for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Tiltle_ID` (`Tiltle_ID`);

--
-- Indeks for tabel `titles`
--
ALTER TABLE `titles`
  ADD PRIMARY KEY (`ID`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `department`
--
ALTER TABLE `department`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tilføj AUTO_INCREMENT i tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- Tilføj AUTO_INCREMENT i tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tilføj AUTO_INCREMENT i tabel `employee`
--
ALTER TABLE `employee`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=163;

--
-- Tilføj AUTO_INCREMENT i tabel `salaries`
--
ALTER TABLE `salaries`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Tilføj AUTO_INCREMENT i tabel `titles`
--
ALTER TABLE `titles`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD CONSTRAINT `dep_employee_ibfk_1` FOREIGN KEY (`Emp_ID`) REFERENCES `employee` (`ID`),
  ADD CONSTRAINT `dep_employee_ibfk_2` FOREIGN KEY (`Dep_ID`) REFERENCES `department` (`ID`),
  ADD CONSTRAINT `dep_employee_ibfk_3` FOREIGN KEY (`Sal_ID`) REFERENCES `salaries` (`ID`),
  ADD CONSTRAINT `dep_employee_ibfk_4` FOREIGN KEY (`Til_ID`) REFERENCES `titles` (`ID`),
  ADD CONSTRAINT `dep_employee_ibfk_5` FOREIGN KEY (`Man_ID`) REFERENCES `dep_manager` (`ID`);

--
-- Begrænsninger for tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD CONSTRAINT `dep_manager_ibfk_1` FOREIGN KEY (`Emp_ID`) REFERENCES `employee` (`ID`),
  ADD CONSTRAINT `dep_manager_ibfk_2` FOREIGN KEY (`Dep_ID`) REFERENCES `department` (`ID`);

--
-- Begrænsninger for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD CONSTRAINT `salaries_ibfk_1` FOREIGN KEY (`Tiltle_ID`) REFERENCES `titles` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
