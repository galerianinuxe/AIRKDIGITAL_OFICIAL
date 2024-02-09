-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 15-Set-2023 às 10:24
-- Versão do servidor: 10.4.28-MariaDB
-- versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `xlata_db`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `registros`
--

CREATE TABLE `registros` (
  `registro_id` int(8) NOT NULL,
  `dataHoraRegistro` datetime DEFAULT NULL,
  `total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `registros`
--

INSERT INTO `registros` (`registro_id`, `dataHoraRegistro`, `total`) VALUES
(0, NULL, 0.00),
(0, NULL, 0.00),
(0, NULL, 0.00),
(0, NULL, 0.00),
(0, NULL, 0.00),
(4, NULL, 0.00),
(0, NULL, 0.00),
(0, NULL, 0.00),
(7, NULL, 0.00),
(8, NULL, 0.00),
(9, NULL, 0.00),
(9, NULL, 0.00),
(9, NULL, 0.00),
(10, NULL, 0.00),
(10, NULL, 0.00),
(11, NULL, 0.00),
(12, NULL, 0.00),
(12, NULL, 0.00),
(12, NULL, 0.00),
(12, NULL, 0.00),
(12, NULL, 0.00),
(13, NULL, 0.00),
(14, '2023-09-13 12:46:33', 0.00),
(15, '2023-09-13 12:55:09', 0.00),
(16, '2023-09-13 12:55:15', 0.00),
(17, '2023-09-13 12:55:21', 0.00),
(18, '2023-09-13 14:03:22', 0.00),
(20, '2023-09-14 22:00:37', 0.00),
(21, '2023-09-14 22:03:36', 22750.00),
(22, '2023-09-14 22:05:01', 52000.00),
(23, '2023-09-14 22:16:29', 32.65),
(24, '2023-09-14 22:18:34', 41.43),
(25, '2023-09-14 22:22:17', 7.56),
(26, '2023-09-14 22:26:12', 7.75),
(27, '2023-09-14 22:30:07', 7.75),
(28, '2023-09-14 22:31:42', 8.07),
(29, '2023-09-14 22:32:46', 1378.94),
(30, '2023-09-14 22:36:09', 15.92),
(31, '2023-09-14 22:37:16', 1592.14),
(32, '2023-09-15 01:29:17', 443.82),
(33, '2023-09-15 01:43:48', 495.82),
(34, '2023-09-15 02:46:11', 511.00),
(35, '2023-09-15 03:03:01', 1021.00);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
