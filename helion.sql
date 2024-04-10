-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Czas generowania: 29 Lis 2017, 14:04
-- Wersja serwera: 5.6.24
-- Wersja PHP: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Baza danych: `helion`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ksiazki`
--

CREATE TABLE IF NOT EXISTS `ksiazki` (
  `TytulID` int(11) NOT NULL,
  `Nazwa` varchar(255) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `ksiazki`
--

INSERT INTO `ksiazki` (`TytulID`, `Nazwa`) VALUES
(1, 'Python dla każdego'),
(2, 'Podstawy SQL Server 2015'),
(3, 'MySQL dla bystrzaków'),
(4, 'C++ w zadaniach'),
(5, 'ASP.NET MVC 5'),
(6, 'Zaawansowany PostgreSQL');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zamowienia`
--

CREATE TABLE IF NOT EXISTS `zamowienia` (
  `ZamowienieID` int(11) NOT NULL,
  `Zamawiajacy` varchar(255) COLLATE utf8_polish_ci NOT NULL,
  `DataZamowienia` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `zamowienia`
--

INSERT INTO `zamowienia` (`ZamowienieID`, `Zamawiajacy`, `DataZamowienia`) VALUES
(1, 'Jan Kowalski', '2017-10-17'),
(2, 'Mariola Kołodziej', '2017-11-19'),
(3, 'Tomasz Głogowski', '2017-11-27'),
(4, 'Jolanta Wieczorek', '2017-11-27');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zamowieniapozycje`
--

CREATE TABLE IF NOT EXISTS `zamowieniapozycje` (
  `PozycjaID` int(11) NOT NULL,
  `ZamowienieID` int(11) NOT NULL,
  `TytulID` int(11) NOT NULL,
  `Ilosc` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `zamowieniapozycje`
--

INSERT INTO `zamowieniapozycje` (`PozycjaID`, `ZamowienieID`, `TytulID`, `Ilosc`) VALUES
(1, 1, 1, 1),
(2, 1, 2, 1),
(3, 2, 2, 2),
(4, 3, 6, 3),
(5, 3, 5, 1),
(6, 4, 5, 2),
(7, 3, 2, 1),
(8, 4, 1, 2),
(9, 2, 3, 1);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `ksiazki`
--
ALTER TABLE `ksiazki`
  ADD PRIMARY KEY (`TytulID`);

--
-- Indexes for table `zamowienia`
--
ALTER TABLE `zamowienia`
  ADD PRIMARY KEY (`ZamowienieID`);

--
-- Indexes for table `zamowieniapozycje`
--
ALTER TABLE `zamowieniapozycje`
  ADD PRIMARY KEY (`PozycjaID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `ksiazki`
--
ALTER TABLE `ksiazki`
  MODIFY `TytulID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT dla tabeli `zamowienia`
--
ALTER TABLE `zamowienia`
  MODIFY `ZamowienieID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT dla tabeli `zamowieniapozycje`
--
ALTER TABLE `zamowieniapozycje`
  MODIFY `PozycjaID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
