-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 20-Set-2023 às 09:13
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
  `valorporkg` decimal(10,2) NOT NULL,
  `detalhes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `materiais`
--

INSERT INTO `materiais` (`id`, `nome`, `valorporkg`, `detalhes`) VALUES
(1, 'CAVACO', 5.20, 'Os cavacos são pequenos pedaços de metal ou madeira que são removidos durante o processo de usinagem. Eles podem ser reciclados para economizar recursos.'),
(2, 'BLOCO LIMPO', 7.00, 'Os blocos limpos geralmente se referem a blocos de metal que não têm contaminação ou impurezas. Isso os torna mais valiosos para reciclagem.'),
(3, 'Bloco Misto', 6.00, 'Os blocos mistos são uma combinação de diferentes tipos de materiais, o que pode tornar sua reciclagem mais complexa.'),
(4, 'Chaparia', 31.20, 'A chaparia é uma folha plana de metal usada em uma variedade de aplicações, incluindo na indústria automobilística e de construção.'),
(5, 'Perfil', 11.90, 'Os perfis de metal têm uma variedade de formas e tamanhos e são frequentemente usados na construção para fornecer estrutura e suporte.'),
(6, 'Panela', 9.00, 'As panelas são frequentemente feitas de metal e podem ser recicladas para criar novos produtos de metal.'),
(8, 'Estamparia', 9.00, 'A estamparia é um processo de fabricação que envolve a formação de peças metálicas planas em formas desejadas, muitas vezes usando prensas.'),
(9, 'Estampa Dura', 9.00, 'A estampa dura refere-se a peças metálicas que passaram por tratamento térmico para torná-las mais resistentes e duráveis.'),
(10, 'Latinha', 6.80, 'As latinhas de alumínio são altamente recicláveis e podem ser fundidas e transformadas em novas latinhas em poucas semanas.'),
(11, 'Roda', 13.50, 'As rodas de metal, quando não podem ser reutilizadas, são recicladas para recuperar os metais e reduzir o desperdício.'),
(12, 'Papel Alumínio', 1.50, 'O papel alumínio é usado em embalagens e culinária. Reciclá-lo economiza energia em comparação com a produção de alumínio primário.'),
(13, 'Rad.AL Cobre', 19.00, 'O radiador de alumínio-cobre é usado em sistemas de resfriamento de veículos. Sua reciclagem ajuda a conservar recursos.'),
(14, 'Aerosol', 8.00, 'Os aerossóis frequentemente contêm produtos químicos inflamáveis e devem ser descartados adequadamente para evitar riscos.'),
(15, 'Metal', 25.20, 'O metal é um material amplamente reciclado, e sua reciclagem economiza energia e recursos naturais.'),
(16, 'Bronze', 28.00, 'O bronze é uma liga de cobre e estanho, conhecida por sua durabilidade e beleza, sendo usada em várias aplicações.'),
(17, 'CAV VERG', 26.00, 'O cavaco de vergalhão é um tipo de resíduo de usinagem de metal que pode ser fundido e reciclado.'),
(18, 'Pontas', 27.00, 'As pontas de metal, quando não podem ser reutilizadas, são recicladas para recuperar os metais e reduzir o desperdício.'),
(19, 'Cav. Refundido', 19.50, 'O cavaco refundido é um material resultante da refusão de cavacos de metal para purificação e reciclagem.'),
(20, 'Rad. Metal', 25.00, 'O radiador de metal é frequentemente encontrado em automóveis e pode ser reciclado para recuperar os metais.'),
(21, 'Cobre Verm.', 39.80, 'O cobre vermelho é uma forma de cobre que pode ser reciclada e refinada para produzir novos produtos de cobre.'),
(22, 'Cobre Queim.', 37.30, 'O cobre queimado refere-se a fios ou cabos de cobre que foram expostos ao fogo, mas ainda podem ser reciclados.'),
(24, 'Fio Encap.', 13.30, 'O fio encapado é um tipo de fio elétrico com revestimento de plástico, que pode ser reciclado para recuperar o cobre.'),
(25, 'Fio Instal.', 24.70, 'O fio instalado é usado em instalações elétricas e pode ser reciclado para recuperar os materiais valiosos.'),
(26, 'Fio PP', 11.00, 'O fio PP (polipropileno) é um tipo de plástico utilizado em fios e cabos elétricos, que pode ser reciclado.'),
(27, 'Inox 304', 6.40, 'O aço inoxidável 304 é conhecido por sua resistência à corrosão e é usado em muitas aplicações, incluindo utensílios de cozinha.'),
(29, 'Chumbo Mole', 8.20, 'O chumbo mole é usado em aplicações como soldagem e baterias, mas seu uso está diminuindo devido a preocupações ambientais.'),
(30, 'Chumbo Seco', 6.00, 'O chumbo seco é usado em baterias automotivas e pode ser reciclado para recuperar o chumbo.'),
(31, 'Chumbo de Roda', 6.00, 'O chumbo de roda é usado como contrapeso em rodas de veículos. Sua reciclagem ajuda a reduzir a contaminação ambiental.'),
(32, 'BATERIAS', 4.65, 'As baterias contêm materiais tóxicos, como chumbo e ácido, e devem ser recicladas adequadamente para evitar danos ambientais.'),
(33, 'Plástico', 0.70, 'O plástico é um material amplamente utilizado, mas sua reciclagem é importante para reduzir a poluição ambiental.'),
(34, 'Papelão', 0.60, 'O papelão é reciclável e amplamente utilizado em embalagens e caixas, sendo importante para a indústria de reciclagem.'),
(35, 'Papel Branco', 0.55, 'O papel branco é uma categoria de papel reciclável, frequentemente usado em escritórios e impressoras.'),
(36, 'Ferro', 0.58, 'O ferro é um dos materiais mais reciclados do mundo, com uma indústria de reciclagem bem estabelecida.'),
(38, 'Eletrônicos', 2.50, 'Os eletrônicos contêm uma variedade de materiais valiosos e tóxicos, e sua reciclagem apropriada é crucial para o meio ambiente.'),
(121, 'CARRO', 1.50, 'Sem descrição'),
(128, 'TV', 0.10, 'Sem descrição'),
(132, 'VIDRO', 0.10, 'Sem descrição'),
(133, 'PLACAS GERAL', 2.00, 'Sem descrição');

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
(87061, 1, 'Baterias', 4.10, 20.50, 5.000, '2023-09-12 23:55:25'),
(87062, 1, 'Cobre 4°', 30.00, 270.00, 9.000, '2023-09-12 23:55:26'),
(87063, 2, 'Inox 304', 6.40, 3.20, 0.500, '2023-09-13 00:48:34'),
(87064, 0, 'Metal', 25.20, 561.96, 22.300, '2023-09-13 00:52:37'),
(87065, 0, 'Cav. Vergalhão', 26.00, 156.00, 6.000, '2023-09-13 00:57:16'),
(87066, 0, 'Papel Alumínio', 1.50, 833.40, 555.600, '2023-09-13 01:04:27'),
(87067, 0, 'Perfil', 11.90, 2867.90, 241.000, '2023-09-13 01:07:23'),
(87068, 0, 'Perfil', 11.90, 2867.90, 241.000, '2023-09-13 01:09:40'),
(87069, 0, 'Latinha', 6.80, 1516.40, 223.000, '2023-09-13 01:12:58'),
(87070, 0, 'Cav. Refundido', 19.50, 8034.00, 412.000, '2023-09-13 01:22:19'),
(87071, 0, 'Baterias', 4.10, 24.60, 6.000, '2023-09-13 01:40:34'),
(87072, 0, 'Cavaco', 5.20, 11554.40, 2222.000, '2023-09-13 01:40:34'),
(87073, 3, 'Cav. Vergalhão', 26.00, 832.00, 32.000, '2023-09-13 01:45:13'),
(87074, 4, 'Cobre 4°', 30.00, 15660.00, 522.000, '2023-09-13 01:49:51'),
(87075, 5, 'Bronze', 28.00, 27972.00, 999.000, '2023-09-13 01:51:14'),
(87076, 6, 'Bronze', 28.00, 27972.00, 999.000, '2023-09-13 01:51:24'),
(87077, 0, 'Cav. Vergalhão', 26.00, 8372.00, 322.000, '2023-09-13 02:02:48'),
(87078, 0, 'Pontas', 27.00, 1416.96, 52.480, '2023-09-13 02:07:05'),
(87079, 7, 'Eletrônicos', 2.50, 140.00, 56.000, '2023-09-13 02:08:07'),
(87080, 8, 'Off-set', 9.00, 5985.00, 665.000, '2023-09-13 02:14:33'),
(87081, 9, 'Bloco Misto', 6.00, 195.60, 32.600, '2023-09-13 02:14:57'),
(87082, 9, 'Cavaco', 5.20, 514.80, 99.000, '2023-09-13 02:14:57'),
(87083, 9, 'Chumbo Mole', 8.20, 197.62, 24.100, '2023-09-13 02:14:57'),
(87084, 10, 'Cav. Refundido', 19.50, 8034.00, 412.000, '2023-09-13 02:21:59'),
(87085, 10, 'Cav. Vergalhão', 26.00, 1352.00, 52.000, '2023-09-13 02:21:59'),
(87086, 11, 'Chumbo Seco', 6.00, 12.60, 2.100, '2023-09-13 02:22:36'),
(87087, 12, 'Aerosol', 8.00, 16.00, 2.000, '2023-09-13 11:56:10'),
(87088, 12, 'Baterias', 4.10, 86.10, 21.000, '2023-09-13 11:56:10'),
(87089, 12, 'Bloco Limpo', 7.00, 245.00, 35.000, '2023-09-13 11:56:10'),
(87090, 12, 'Bloco Misto', 6.00, 324.00, 54.000, '2023-09-13 11:56:10'),
(87091, 12, 'Bronze', 28.00, 182.00, 6.500, '2023-09-13 11:56:10'),
(87092, 13, 'Cobre Queim.', 37.30, 130.55, 3.500, '2023-09-13 12:39:49'),
(87093, 13, 'Chumbo Seco', 6.00, 210.00, 35.000, '2023-09-13 12:39:49'),
(87094, 13, 'Fio PP', 11.00, 165.11, 15.010, '2023-09-13 12:39:49'),
(87095, 14, 'Pontas', 27.00, 1458.00, 54.000, '2023-09-13 12:46:33'),
(87096, 14, 'Zamack', 12.30, 405.90, 33.000, '2023-09-13 12:46:33'),
(87097, 14, 'Vidro', 0.10, 0.21, 2.100, '2023-09-13 12:46:33'),
(87098, 15, 'Pontas', 27.00, 1458.00, 54.000, '2023-09-13 12:55:09'),
(87099, 15, 'Zamack', 12.30, 405.90, 33.000, '2023-09-13 12:55:09'),
(87100, 15, 'Vidro', 0.10, 0.21, 2.100, '2023-09-13 12:55:09'),
(87101, 16, 'Baterias', 4.10, 8.61, 2.100, '2023-09-13 12:55:15'),
(87102, 17, 'Eletrônicos', 2.50, 6.18, 2.470, '2023-09-13 12:55:21'),
(87103, 17, 'Estamparia', 9.00, 288.00, 32.000, '2023-09-13 12:55:22'),
(87104, 18, 'Baterias', 4.10, 131.65, 32.110, '2023-09-13 14:03:22'),
(87105, 18, 'Eletrônicos', 2.50, 52.50, 21.000, '2023-09-13 14:03:23'),
(87106, 19, 'Bloco Limpo', 7.00, 227.50, 32.500, '2023-09-14 21:59:17'),
(87107, 19, 'Aerosol', 8.00, 296.00, 37.000, '2023-09-14 21:59:17'),
(87108, 19, 'Fio PP', 11.00, 23.10, 2.100, '2023-09-14 21:59:17'),
(87109, 20, 'Bloco Limpo', 7.00, 227.50, 32.500, '2023-09-14 22:00:37'),
(87110, 20, 'Aerosol', 8.00, 296.00, 37.000, '2023-09-14 22:00:37'),
(87111, 20, 'Fio PP', 11.00, 23.10, 2.100, '2023-09-14 22:00:37'),
(87112, 21, 'Bloco Limpo', 7.00, 227.50, 32.500, '2023-09-14 22:03:36'),
(87113, 21, 'Aerosol', 8.00, 296.00, 37.000, '2023-09-14 22:03:36'),
(87114, 21, 'Fio PP', 11.00, 23.10, 2.100, '2023-09-14 22:03:36'),
(87115, 21, 'Cav. Vergalhão', 26.00, 62.40, 2.400, '2023-09-14 22:03:36'),
(87116, 21, 'Inox 304', 6.40, 422.40, 66.000, '2023-09-14 22:03:36'),
(87117, 22, 'Aerosol', 8.00, 520.00, 65.000, '2023-09-14 22:05:01'),
(87118, 22, 'Baterias', 4.10, 10.25, 2.500, '2023-09-14 22:05:01'),
(87119, 23, 'Aerosol', 8.00, 520.00, 65.000, '2023-09-14 22:16:29'),
(87120, 23, 'Baterias', 4.10, 10.25, 2.500, '2023-09-14 22:16:29'),
(87121, 23, 'Chumbo Mole', 8.20, 509.22, 62.100, '2023-09-14 22:16:29'),
(87122, 23, 'Cobre 4°', 30.00, 2226.00, 74.200, '2023-09-14 22:16:29'),
(87123, 24, 'Aerosol', 8.00, 520.00, 65.000, '2023-09-14 22:18:34'),
(87124, 24, 'Baterias', 4.10, 10.25, 2.500, '2023-09-14 22:18:34'),
(87125, 24, 'Chumbo Mole', 8.20, 509.22, 62.100, '2023-09-14 22:18:34'),
(87126, 24, 'Cobre 4°', 30.00, 2226.00, 74.200, '2023-09-14 22:18:34'),
(87127, 24, 'Baterias', 4.10, 877.40, 214.000, '2023-09-14 22:18:35'),
(87128, 25, 'Chumbo Seco', 600.00, 1290.00, 2.150, '2023-09-14 22:22:17'),
(87129, 25, 'Aerosol', 800.00, 25680.00, 32.100, '2023-09-14 22:22:17'),
(87130, 25, 'Panela', 900.00, 48600.00, 54.000, '2023-09-14 22:22:17'),
(87131, 26, 'Chumbo Seco', 6.00, 12.90, 2.150, '2023-09-14 22:26:12'),
(87132, 26, 'Aerosol', 8.00, 256.80, 32.100, '2023-09-14 22:26:13'),
(87133, 26, 'Panela', 9.00, 486.00, 54.000, '2023-09-14 22:26:13'),
(87134, 26, 'Chumbo Seco', 6.00, 18.90, 3.150, '2023-09-14 22:26:13'),
(87135, 27, 'Chumbo Seco', 6.00, 12.90, 2.150, '2023-09-14 22:30:07'),
(87136, 27, 'Aerosol', 8.00, 256.80, 32.100, '2023-09-14 22:30:07'),
(87137, 27, 'Panela', 9.00, 486.00, 54.000, '2023-09-14 22:30:07'),
(87138, 27, 'Chumbo Seco', 6.00, 18.90, 3.150, '2023-09-14 22:30:07'),
(87139, 28, 'Chumbo Seco', 6.00, 12.90, 2.150, '2023-09-14 22:31:42'),
(87140, 28, 'Aerosol', 8.00, 256.80, 32.100, '2023-09-14 22:31:42'),
(87141, 28, 'Panela', 9.00, 486.00, 54.000, '2023-09-14 22:31:42'),
(87142, 28, 'Chumbo Seco', 6.00, 18.90, 3.150, '2023-09-14 22:31:42'),
(87143, 28, 'Cavaco', 5.20, 32.34, 6.220, '2023-09-14 22:31:42'),
(87144, 29, 'Chumbo Seco', 6.00, 12.90, 2.150, '2023-09-14 22:32:46'),
(87145, 29, 'Aerosol', 8.00, 256.80, 32.100, '2023-09-14 22:32:46'),
(87146, 29, 'Panela', 9.00, 486.00, 54.000, '2023-09-14 22:32:46'),
(87147, 29, 'Chumbo Seco', 6.00, 18.90, 3.150, '2023-09-14 22:32:46'),
(87148, 29, 'Cavaco', 5.20, 32.34, 6.220, '2023-09-14 22:32:46'),
(87149, 29, 'Fio PP', 11.00, 572.00, 52.000, '2023-09-14 22:32:46'),
(87150, 30, 'Chumbo Seco', 6.00, 12.90, 2.150, '2023-09-14 22:36:09'),
(87151, 30, 'Aerosol', 8.00, 256.80, 32.100, '2023-09-14 22:36:09'),
(87152, 30, 'Panela', 9.00, 486.00, 54.000, '2023-09-14 22:36:09'),
(87153, 30, 'Chumbo Seco', 6.00, 18.90, 3.150, '2023-09-14 22:36:09'),
(87154, 30, 'Cavaco', 5.20, 32.34, 6.220, '2023-09-14 22:36:09'),
(87155, 30, 'Fio PP', 11.00, 572.00, 52.000, '2023-09-14 22:36:09'),
(87156, 30, 'Baterias', 4.10, 213.20, 52.000, '2023-09-14 22:36:09'),
(87157, 31, 'Chumbo Seco', 6.00, 12.90, 2.150, '2023-09-14 22:37:16'),
(87158, 31, 'Aerosol', 8.00, 256.80, 32.100, '2023-09-14 22:37:16'),
(87159, 31, 'Panela', 9.00, 486.00, 54.000, '2023-09-14 22:37:16'),
(87160, 31, 'Chumbo Seco', 6.00, 18.90, 3.150, '2023-09-14 22:37:16'),
(87161, 31, 'Cavaco', 5.20, 32.34, 6.220, '2023-09-14 22:37:16'),
(87162, 31, 'Fio PP', 11.00, 572.00, 52.000, '2023-09-14 22:37:16'),
(87163, 31, 'Baterias', 4.10, 213.20, 52.000, '2023-09-14 22:37:16'),
(87164, 32, 'Chumbo Seco', 6.00, 372.00, 62.000, '2023-09-15 01:29:17'),
(87165, 32, 'Estampa Dura', 9.00, 18.90, 2.100, '2023-09-15 01:29:18'),
(87166, 32, 'Metal', 25.20, 52.92, 2.100, '2023-09-15 01:29:18'),
(87167, 33, 'Chumbo Seco', 6.00, 372.00, 62.000, '2023-09-15 01:43:48'),
(87168, 33, 'Estampa Dura', 9.00, 18.90, 2.100, '2023-09-15 01:43:48'),
(87169, 33, 'Metal', 25.20, 52.92, 2.100, '2023-09-15 01:43:48'),
(87170, 33, 'Cav. Vergalhão', 26.00, 52.00, 2.000, '2023-09-15 01:43:48'),
(87171, 34, 'Bloco Limpo', 7.00, 511.00, 73.000, '2023-09-15 02:46:11'),
(87172, 35, 'Bloco Limpo', 7.00, 511.00, 73.000, '2023-09-15 03:03:01'),
(87173, 35, 'Chumbo Seco', 6.00, 510.00, 85.000, '2023-09-15 03:03:01'),
(87174, 36, 'CAVACO', 5.20, 26.00, 5.000, '2023-09-16 19:11:58'),
(87175, 37, 'CAVACO', 5.20, 41.60, 8.000, '2023-09-16 19:12:53'),
(87176, 37, 'Chaparia', 31.20, 1123.20, 36.000, '2023-09-16 19:12:53'),
(87177, 38, 'Ferro', 0.58, 1.80, 3.110, '2023-09-16 22:50:28'),
(87178, 38, 'Metal', 25.20, 60.48, 2.400, '2023-09-16 22:50:29'),
(87179, 38, 'BATERIAS', 4.65, 12.88, 2.770, '2023-09-16 22:50:29'),
(87180, 39, 'Ferro', 0.58, 13.80, 23.800, '2023-09-16 22:50:58'),
(87181, 40, 'CAVACO', 5.20, 6.24, 1.200, '2023-09-16 22:52:48'),
(87182, 40, 'CAVACO', 5.20, 10.92, 2.100, '2023-09-16 22:52:48'),
(87183, 40, 'CAVACO', 5.20, 18.20, 3.500, '2023-09-16 22:52:48'),
(87184, 40, 'Ferro', 0.58, 20.82, 35.900, '2023-09-16 22:52:48'),
(87185, 41, 'CAVACO', 5.20, 494.52, 95.100, '2023-09-16 23:04:09'),
(87186, 42, 'Cobre Queim.', 37.30, 93.25, 2.500, '2023-09-17 00:34:58'),
(87187, 42, 'Cav. Refundido', 19.50, 16692.00, 856.000, '2023-09-17 00:34:58'),
(87188, 43, 'Chaparia', 31.20, 280.80, 9.000, '2023-09-19 05:29:29');

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
(35, '2023-09-15 03:03:01', 1021.00),
(36, '2023-09-16 19:11:58', 26.00),
(37, '2023-09-16 19:12:53', 1164.80),
(38, '2023-09-16 22:50:28', 75.16),
(39, '2023-09-16 22:50:58', 13.80),
(40, '2023-09-16 22:52:48', 56.18),
(41, '2023-09-16 23:04:09', 494.52),
(42, '2023-09-17 00:34:58', 16785.25),
(43, '2023-09-19 05:29:29', 280.80);

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas`
--

CREATE TABLE `vendas` (
  `id_venda` int(11) NOT NULL,
  `produto_venda` varchar(255) NOT NULL,
  `valor_unit` decimal(10,2) DEFAULT NULL,
  `valor_venda` decimal(10,2) NOT NULL,
  `forma_pagamento` varchar(255) DEFAULT NULL,
  `quantidade_venda` int(11) NOT NULL,
  `dataVenda` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `vendas`
--

INSERT INTO `vendas` (`id_venda`, `produto_venda`, `valor_unit`, `valor_venda`, `forma_pagamento`, `quantidade_venda`, `dataVenda`) VALUES
(4, 'INOX 304', 9180.00, 1530.00, NULL, 6, '2023-09-20 02:09:31'),
(5, 'RAMPAS DE FERRO', 720.00, 120.00, NULL, 6, '2023-09-20 02:09:53'),
(6, 'RESTO', 4000.00, 1000.00, NULL, 4, '2023-09-20 02:10:29'),
(7, 'COMBOS 33', 15126.00, 1260.50, NULL, 12, '2023-09-20 02:12:18'),
(8, 'RIPA DE MADEIRA', 18.00, 2.00, NULL, 9, '2023-09-20 02:15:19'),
(9, 'VEND', 50.00, 200.00, NULL, 4, '2023-09-20 02:16:33'),
(10, 'VENTILADOR', 40.00, 320.00, NULL, 8, '2023-09-20 02:18:14'),
(11, 'CATALISADOR', 129.50, 1036.00, NULL, 8, '2023-09-20 02:31:03'),
(12, 'FERRAGEM', 3450.00, 20700.00, NULL, 6, '2023-09-20 02:39:50'),
(13, 'TV', 50.00, 300.00, 'PIX', 6, '2023-09-20 04:12:05'),
(14, 'DESTROÇO', 750.00, 4500.00, 'Crédito', 6, '2023-09-20 04:12:37');

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
-- Índices para tabela `vendas`
--
ALTER TABLE `vendas`
  ADD PRIMARY KEY (`id_venda`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `materiais`
--
ALTER TABLE `materiais`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=134;

--
-- AUTO_INCREMENT de tabela `pedidos_impressos`
--
ALTER TABLE `pedidos_impressos`
  MODIFY `id_item` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87189;

--
-- AUTO_INCREMENT de tabela `vendas`
--
ALTER TABLE `vendas`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
