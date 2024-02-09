-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24-Nov-2023 às 23:32
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
(1, 'LATINHA', 4.50, 'Sem descrição'),
(2, 'COBRE', 28.00, 'Sem descrição'),
(3, 'BLOCO LIMPO', 4.00, 'Sem descrição'),
(4, 'CHAPARIA', 4.50, 'Sem descrição'),
(5, 'AEROSOL2', 5.00, 'Sem descrição'),
(6, 'PANELA LIMPA', 7.00, 'Sem descrição'),
(7, 'CABO ALUMINIO', 8.00, 'Sem descrição'),
(8, 'METAL-LATAO', 15.00, 'Sem descrição'),
(9, 'PERFIL MISTO', 6.00, 'Sem descrição'),
(10, 'RODA ALUMINIO', 8.00, 'Sem descrição'),
(11, 'RAD ALUMINIO', 4.50, 'Sem descrição'),
(12, 'ANTIMONIO', 5.00, 'Sem descrição'),
(13, 'RAD METAL', 16.00, 'Sem descrição'),
(14, 'RAD COBRE', 14.00, 'Sem descrição'),
(15, 'BATERIA', 2.50, 'Sem descrição'),
(16, 'ALUM OFFSET', 8.00, 'Sem descrição'),
(17, 'CHUMBO', 2.50, 'Sem descrição'),
(18, 'FERRO LEVE', 0.50, 'Sem descrição'),
(19, 'FERRO PESADO', 0.50, 'Sem descrição'),
(20, 'PET', 0.60, 'Sem descrição'),
(21, 'BALDE-BACIA', 0.50, 'Sem descrição'),
(22, 'SOPRO', 0.60, 'Sem descrição'),
(23, 'PVC', 0.30, 'Sem descrição'),
(24, 'PLASTICO FINO', 0.70, 'Sem descrição'),
(25, 'CADEIRA', 0.70, 'Sem descrição'),
(26, 'GRADE', 0.70, 'Sem descrição');

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
  `dataHoraAtual` datetime DEFAULT NULL,
  `nomeCliente` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `registros`
--

CREATE TABLE `registros` (
  `registro_id` int(8) NOT NULL,
  `dataHoraRegistro` datetime DEFAULT NULL,
  `total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas_kg`
--

CREATE TABLE `vendas_kg` (
  `id_venda` int(11) NOT NULL,
  `produto_venda` varchar(255) NOT NULL,
  `valor_kg` decimal(10,2) DEFAULT NULL,
  `valor_venda` decimal(10,2) NOT NULL,
  `forma_pagamento` varchar(255) DEFAULT NULL,
  `peso_venda` decimal(10,3) NOT NULL,
  `dataVenda` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
-- Índices para tabela `vendas_kg`
--
ALTER TABLE `vendas_kg`
  ADD PRIMARY KEY (`id_venda`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `materiais`
--
ALTER TABLE `materiais`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de tabela `pedidos_impressos`
--
ALTER TABLE `pedidos_impressos`
  MODIFY `id_item` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=226;

--
-- AUTO_INCREMENT de tabela `vendas`
--
ALTER TABLE `vendas`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `vendas_kg`
--
ALTER TABLE `vendas_kg`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
