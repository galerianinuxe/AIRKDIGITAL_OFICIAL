-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 02-Set-2023 às 08:53
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
-- Estrutura da tabela `materiais`
--

CREATE TABLE `materiais` (
  `id` int(11) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `valorporkg` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `materiais`
--

INSERT INTO `materiais` (`id`, `nome`, `valorporkg`) VALUES
(57, 'Ferro', 0.48),
(58, 'Cobre 1°', 52.20),
(59, 'Cobre 2°', 31.20),
(60, 'Cobre 3°', 24.80),
(61, 'Metal', 12.50),
(62, 'Inox', 2.70),
(63, 'Alumínio 1', 30.51),
(64, 'Alumínio 2', 5.89),
(65, 'Alumínio 3', 3.80),
(66, 'Alumínio 4', 2.30),
(67, 'Papelão', 0.19),
(68, 'Papel Branco', 0.40),
(69, 'Papel Colorido', 0.12),
(70, 'Papel Misto', 0.44),
(71, 'Latinha', 7.70),
(72, 'Fio Tipo 1', 23.00),
(73, 'Fio Tipo 2', 8.70),
(74, 'Fio Tipo 3', 10.30),
(75, 'Vidro Misto', 0.13),
(76, 'Vidro T 2', 0.00),
(77, 'Vidro T 3', 0.00),
(78, 'Eletrônico 1', 0.00),
(79, 'Eletrônico 2', 5.70),
(80, 'Eletrônico 3', 7.35),
(81, 'Eletrônico 4', 0.00),
(82, 'Plástico Misto', 0.30),
(83, 'Plástico T 2', 0.00),
(84, 'Plástico T 3', 0.12),
(85, 'Plástico PVC', 1.32),
(86, 'Plástico PS', 0.00),
(87, 'Bloco 1', 0.90),
(88, 'Bloco 2', 0.00),
(89, 'Material S/ Seleção', 1.72);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedidos_impressos`
--

CREATE TABLE `pedidos_impressos` (
  `id_item` int(11) NOT NULL,
  `id_registro` int(5) NOT NULL,
  `materialNome` varchar(40) NOT NULL,
  `materialValor` decimal(10,2) DEFAULT NULL,
  `totalPagar` decimal(10,2) DEFAULT NULL,
  `inputValor` decimal(10,3) DEFAULT NULL,
  `dataHoraAtual` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `pedidos_impressos`
--

INSERT INTO `pedidos_impressos` (`id_item`, `id_registro`, `materialNome`, `materialValor`, `totalPagar`, `inputValor`, `dataHoraAtual`) VALUES
(86973, 1, 'Alumínio 2', 6.40, 20.54, 3.210, '2023-08-31 13:19:22'),
(86974, 1, 'Papel Branco', 0.40, 38.04, 95.100, '2023-08-31 13:19:22'),
(86975, 1, 'Papel Misto', 0.44, 1.32, 2.990, '2023-08-31 13:19:22'),
(86976, 1, 'Fio Tipo 3', 15.70, 31.71, 2.020, '2023-08-31 13:19:22'),
(86977, 2, 'Latinha', 7.70, 38.50, 5.000, '2023-08-31 13:53:36'),
(86978, 2, 'Alumínio 1', 30.10, 2570.84, 85.410, '2023-08-31 13:53:36'),
(86979, 2, 'Papel Colorido', 0.12, 0.62, 5.200, '2023-08-31 13:53:36'),
(86980, 3, 'Alumínio 1', 30.51, 111.06, 3.640, '2023-08-31 17:29:17'),
(86981, 3, 'Papel Colorido', 0.12, 0.32, 2.660, '2023-08-31 17:29:17'),
(86982, 3, 'Cobre 2°', 31.20, 810.89, 25.990, '2023-08-31 17:29:17'),
(86983, 3, 'Alumínio 1', 30.51, 64.07, 2.100, '2023-08-31 17:29:17'),
(86984, 3, 'Papel Branco', 0.40, 2.60, 6.500, '2023-08-31 17:29:17'),
(86985, 3, 'Vidro Misto', 0.07, 0.15, 2.180, '2023-08-31 17:29:17'),
(86986, 3, 'Papel Misto', 0.44, 25.58, 58.140, '2023-08-31 17:29:17'),
(86987, 4, 'Fio Tipo 3', 15.70, 477.44, 30.410, '2023-08-31 17:40:41'),
(86988, 4, 'Vidro Misto', 0.07, 4.78, 68.290, '2023-08-31 17:40:41'),
(86989, 4, 'Cobre 1°', 52.20, 143.03, 2.740, '2023-08-31 17:40:41'),
(86990, 4, 'Papelão', 0.19, 0.75, 3.970, '2023-08-31 17:40:41'),
(86991, 5, 'Fio Tipo 3', 15.70, 475.24, 30.270, '2023-08-31 17:45:24'),
(86992, 5, 'Latinha', 7.70, 702.47, 91.230, '2023-08-31 17:45:24'),
(86993, 5, 'Papel Colorido', 0.12, 9.04, 75.300, '2023-08-31 17:45:24'),
(86994, 5, 'Metal', 12.50, 313.00, 25.040, '2023-08-31 17:45:24'),
(86995, 5, 'Ferro', 0.62, 36.67, 59.140, '2023-08-31 17:45:24'),
(86996, 5, 'Cobre 1°', 52.20, 1129.61, 21.640, '2023-08-31 17:45:24'),
(86997, 5, 'Alumínio 3', 3.80, 10.79, 2.840, '2023-08-31 17:45:24'),
(86998, 5, 'Ferro', 0.62, 1.51, 2.440, '2023-08-31 17:45:24'),
(86999, 5, 'Ferro', 0.62, 10.79, 17.400, '2023-08-31 17:45:24'),
(87000, 5, 'Inox', 2.70, 139.51, 51.670, '2023-08-31 17:45:24'),
(87001, 6, 'Ferro', 0.62, 20.18, 32.550, '2023-08-31 18:05:41'),
(87002, 6, 'Cobre 1°', 52.20, 1336.32, 25.600, '2023-08-31 18:05:41'),
(87003, 6, 'Inox', 2.70, 637.20, 236.000, '2023-08-31 18:05:41'),
(87004, 6, 'Fio Tipo 3', 15.70, 116.18, 7.400, '2023-08-31 18:05:41'),
(87005, 6, 'Latinha', 7.70, 181.34, 23.550, '2023-08-31 18:05:41'),
(87006, 7, 'Papel Branco', 0.40, 0.86, 2.140, '2023-08-31 22:43:51'),
(87007, 7, 'Alumínio 3', 3.80, 11.32, 2.980, '2023-08-31 22:43:51'),
(87008, 7, 'Fio Tipo 1', 23.00, 2118.30, 92.100, '2023-08-31 22:43:51'),
(87009, 8, 'Alumínio 2', 6.40, 20.48, 3.200, '2023-08-31 22:47:18'),
(87010, 8, 'Papel Branco', 0.40, 1.02, 2.550, '2023-08-31 22:47:18'),
(87011, 8, 'Papel Misto', 0.44, 17.01, 38.660, '2023-08-31 22:47:18'),
(87012, 8, 'Alumínio 4', 2.30, 143.68, 62.470, '2023-08-31 22:47:18'),
(87013, 8, 'Fio Tipo 1', 23.00, 753.71, 32.770, '2023-08-31 22:47:18'),
(87014, 9, 'Alumínio 2', 6.40, 33.09, 5.170, '2023-09-01 01:33:11'),
(87015, 9, 'Cobre 1°', 52.20, 271.44, 5.200, '2023-09-01 01:33:11'),
(87016, 9, 'Latinha', 7.70, 40.81, 5.300, '2023-09-01 01:33:11'),
(87017, 10, 'Alumínio 1', 30.51, 1589.88, 52.110, '2023-09-01 18:35:11'),
(87018, 11, 'Cobre 3°', 24.80, 1302.00, 52.500, '2023-09-01 20:55:15'),
(87019, 11, 'Ferro', 0.62, 40.45, 65.240, '2023-09-01 20:55:16'),
(87020, 11, 'Papel Colorido', 0.12, 1.76, 14.660, '2023-09-01 20:55:16'),
(87021, 11, 'Ferro', 0.62, 202.81, 327.110, '2023-09-01 20:55:16'),
(87022, 0, 'Alumínio 2', 5.69, 547.66, 96.250, '2023-09-01 22:42:19'),
(87023, 0, 'Alumínio 1', 30.51, 1098.36, 36.000, '2023-09-01 22:42:19'),
(87024, 12, 'Cobre 2°', 31.20, 734.76, 23.550, '2023-09-02 00:28:51'),
(87025, 12, 'Papel Colorido', 0.12, 0.26, 2.180, '2023-09-02 00:28:51'),
(87026, 13, 'Metal', 12.50, 77.12, 6.170, '2023-09-02 00:37:38'),
(87027, 13, 'Alumínio 1', 30.51, 32.04, 1.050, '2023-09-02 00:37:38'),
(87028, 14, 'Cobre 2°', 31.20, 733.20, 23.500, '2023-09-02 00:39:30'),
(87029, 15, 'Inox', 2.70, 55.63, 20.600, '2023-09-02 00:40:50'),
(87030, 15, 'Vidro Misto', 0.07, 17.61, 251.580, '2023-09-02 00:40:50'),
(87031, 16, 'Papel Colorido', 0.12, 30.48, 254.000, '2023-09-02 00:44:00'),
(87032, 16, 'Papel Misto', 0.44, 160.16, 364.000, '2023-09-02 00:44:00'),
(87033, 16, 'Eletrônico 2', 5.70, 117.65, 20.640, '2023-09-02 00:44:00'),
(87034, 17, 'Cobre 1°', 52.20, 1699.11, 32.550, '2023-09-02 00:57:10'),
(87035, 17, 'Fio Tipo 1', 23.00, 56.12, 2.440, '2023-09-02 00:57:10'),
(87036, 17, 'Fio Tipo 1', 23.00, 81.65, 3.550, '2023-09-02 00:57:10'),
(87037, 17, 'Vidro Misto', 0.07, 17.78, 254.000, '2023-09-02 00:57:10'),
(87038, 18, 'Alumínio 3', 3.80, 9.50, 2.500, '2023-09-02 00:59:12'),
(87039, 18, 'Cobre 1°', 52.20, 34556.40, 662.000, '2023-09-02 00:59:12'),
(87040, 18, 'Papelão', 0.19, 17.29, 91.000, '2023-09-02 00:59:12'),
(87041, 18, 'Papel Branco', 0.40, 13.80, 34.500, '2023-09-02 00:59:12'),
(87042, 18, 'Papel Branco', 0.40, 102.08, 255.200, '2023-09-02 00:59:12'),
(87043, 19, 'Cobre 2°', 31.20, 110.76, 3.550, '2023-09-02 01:01:57'),
(87044, 19, 'Alumínio 1', 30.51, 74.44, 2.440, '2023-09-02 01:01:57'),
(87045, 19, 'Fio Tipo 1', 23.00, 5865.00, 255.000, '2023-09-02 01:01:57'),
(87046, 19, 'Ferro', 0.62, 327.36, 528.000, '2023-09-02 01:01:57'),
(87047, 19, 'Cobre 1°', 52.20, 13311.00, 255.000, '2023-09-02 01:01:57'),
(87048, 19, 'Cobre 3°', 24.80, 88833.60, 3582.000, '2023-09-02 01:01:57'),
(87049, 19, 'Cobre 1°', 52.20, 49851.00, 955.000, '2023-09-02 01:01:57'),
(87050, 19, 'Cobre 1°', 52.20, 132953.40, 2547.000, '2023-09-02 01:01:57'),
(87051, 20, 'Cobre 1°', 52.20, 16965.00, 325.000, '2023-09-02 01:03:36'),
(87052, 20, 'Cobre 1°', 52.20, 169180.20, 3241.000, '2023-09-02 01:03:36'),
(87053, 21, 'Cobre 1°', 52.20, 2719.62, 52.100, '2023-09-02 01:42:23'),
(87054, 21, 'Papelão', 0.19, 0.59, 3.110, '2023-09-02 01:42:23'),
(87055, 22, 'Papel Misto', 0.44, 28.69, 65.210, '2023-09-02 03:02:00'),
(87056, 22, 'Latinha', 7.70, 249.79, 32.440, '2023-09-02 03:02:00'),
(87057, 23, 'Ferro', 0.62, 15.10, 24.350, '2023-09-02 03:09:10'),
(87058, 23, 'Papelão', 0.19, 4.83, 25.410, '2023-09-02 03:09:10'),
(87059, 23, 'Cobre 1°', 52.20, 153.47, 2.940, '2023-09-02 03:09:10'),
(87060, 23, 'Papel Colorido', 0.12, 0.42, 3.510, '2023-09-02 03:09:10');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `materiais`
--
ALTER TABLE `materiais`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `pedidos_impressos`
--
ALTER TABLE `pedidos_impressos`
  ADD PRIMARY KEY (`id_item`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `materiais`
--
ALTER TABLE `materiais`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=90;

--
-- AUTO_INCREMENT de tabela `pedidos_impressos`
--
ALTER TABLE `pedidos_impressos`
  MODIFY `id_item` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87061;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;