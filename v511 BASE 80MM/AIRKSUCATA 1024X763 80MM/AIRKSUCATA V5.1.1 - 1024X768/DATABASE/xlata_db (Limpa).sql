-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 28-Out-2023 às 01:01
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
(13, 'Rad.AL Cobre', 19.00, 'O radiador de alumínio-cobre é usado em sistemas de resfriamento de veículos. Sua reciclagem ajuda a conservar recursos.'),
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=172;

--
-- AUTO_INCREMENT de tabela `pedidos_impressos`
--
ALTER TABLE `pedidos_impressos`
  MODIFY `id_item` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87260;

--
-- AUTO_INCREMENT de tabela `vendas`
--
ALTER TABLE `vendas`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT de tabela `vendas_kg`
--
ALTER TABLE `vendas_kg`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
