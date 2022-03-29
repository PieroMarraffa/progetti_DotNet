-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Creato il: Mar 29, 2022 alle 15:47
-- Versione del server: 10.4.21-MariaDB
-- Versione PHP: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `PrestFast`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `persona`
--

CREATE TABLE `persona` (
  `idPersona` int(11) NOT NULL,
  `Nome` varchar(15) NOT NULL,
  `Cognome` varchar(15) NOT NULL,
  `CodiceFiscale` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `persona`
--

INSERT INTO `persona` (`idPersona`, `Nome`, `Cognome`, `CodiceFiscale`) VALUES
(6, 'PIERO', 'MARRAFFA', 'MRRPRI99T24A345X'),
(7, 'ADMIN', 'ADMIN', 'ADMINCOMANDANTE0');

-- --------------------------------------------------------

--
-- Struttura della tabella `prestitiAttivi`
--

CREATE TABLE `prestitiAttivi` (
  `idPrestito` int(11) NOT NULL,
  `idPersona` int(11) NOT NULL,
  `importo` double NOT NULL,
  `nRate` int(11) NOT NULL,
  `esito` tinyint(1) NOT NULL,
  `dataAttivazione` varchar(10) DEFAULT NULL,
  `dataRichiesta` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `prestitiAttivi`
--

INSERT INTO `prestitiAttivi` (`idPrestito`, `idPersona`, `importo`, `nRate`, `esito`, `dataAttivazione`, `dataRichiesta`) VALUES
(4, 6, 4500, 50, 1, '', '3/29/2022'),
(5, 6, 4500, 40, 0, '', '3/29/2022');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`idPersona`);

--
-- Indici per le tabelle `prestitiAttivi`
--
ALTER TABLE `prestitiAttivi`
  ADD PRIMARY KEY (`idPrestito`),
  ADD KEY `idPersona` (`idPersona`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `persona`
--
ALTER TABLE `persona`
  MODIFY `idPersona` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT per la tabella `prestitiAttivi`
--
ALTER TABLE `prestitiAttivi`
  MODIFY `idPrestito` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `prestitiAttivi`
--
ALTER TABLE `prestitiAttivi`
  ADD CONSTRAINT `prestitiattivi_ibfk_1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
