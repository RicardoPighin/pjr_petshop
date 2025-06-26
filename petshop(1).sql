-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 26-Jun-2025 às 00:12
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `petshop`
--
CREATE DATABASE IF NOT EXISTS `petshop` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `petshop`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `cpf` varchar(14) NOT NULL,
  `nome` varchar(70) NOT NULL,
  `email` varchar(70) NOT NULL,
  `celular` varchar(10) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `cidade` varchar(50) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `logradouro` varchar(70) NOT NULL,
  `numero_casa` varchar(10) NOT NULL,
  `foto` varchar(255) NOT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`cpf`, `nome`, `email`, `celular`, `cep`, `uf`, `cidade`, `bairro`, `logradouro`, `numero_casa`, `foto`) VALUES
('11111111111', 'TESTE SEGUNDO', 'TESTESEGUNDO@EMAIL.COM', '91212-1212', '09687-100', 'SP', 'SÃO BERNARDO DO CAMPO', 'PAULICÉIA', 'RUA GENERAL IZIDORO DIAS LOPES', '523', 'D:/projeto_interdisciplinar/pjr_petshop/bin/Debug/fotos_clientes/foto_cliente.jpg'),
('12345678900', 'CLIENTE PRIMEIRO', 'CLIENTEPRIMEIRO@EMAIL.COM', '91111-1111', '58410-235', 'PB', 'CAMPINA GRANDE', 'CATOLÉ', 'RUA TOMÁS SOARES DE SOUZA', '124', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `compra`
--

CREATE TABLE IF NOT EXISTS `compra` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data_compra` varchar(35) NOT NULL,
  `cpf_cliente` varchar(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Extraindo dados da tabela `compra`
--

INSERT INTO `compra` (`id`, `data_compra`, `cpf_cliente`) VALUES
(1, '24/06/2025 23:46:55', '11111111111'),
(2, '24/06/2025 23:47:57', '11111111111'),
(3, '25/06/2025 00:35:10', '11111111111'),
(4, '25/06/2025 20:22:27', '11111111111'),
(5, '25/06/2025 20:23:56', '11111111111'),
(6, '25/06/2025 20:27:04', '11111111111'),
(7, '25/06/2025 20:33:29', '11111111111'),
(8, '25/06/2025 20:33:43', '11111111111');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE IF NOT EXISTS `funcionario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cpf` varchar(14) NOT NULL,
  `nome` varchar(70) NOT NULL,
  `email` varchar(70) NOT NULL,
  `celular` varchar(10) NOT NULL,
  `senha` varchar(255) NOT NULL,
  `cargo` varchar(20) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `cidade` varchar(50) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `logradouro` varchar(70) NOT NULL,
  `numero_casa` varchar(20) NOT NULL,
  `foto` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`id`, `cpf`, `nome`, `email`, `celular`, `senha`, `cargo`, `cep`, `uf`, `cidade`, `bairro`, `logradouro`, `numero_casa`, `foto`) VALUES
(1, '11111111111', 'GERENTE', 'TESTE@EMAIL.COM', '91111-1111', 'Ab', 'GERENTE', '09687-100', 'SP', 'SÃO BERNARDO DO CAMPO', 'PAULICÉIA', 'RUA GENERAL IZIDORO DIAS LOPES', '769', 'D:/projeto_interdisciplinar/pjr_petshop/bin/Debug/fotos_clientes/foto_cliente.jpg'),
(6, '22222222222', 'CAIXA', 'CAIXA@EMAIL.COM', '92222-2222', '1A', 'CAIXA', '13076-029', 'SP', 'CAMPINAS', 'TAQUARAL', 'PRAÇA ALEXO VILLANI', '232', 'D:/projeto_interdisciplinar/pjr_petshop/bin/Debug/fotos_clientes/foto_cliente.jpg'),
(7, '33333333333', 'ATENDENTE', 'ATENDENTE@EMAIL.COM', '93333-3333', 'Ab', 'ATENDENTE', '09961-853', 'SP', 'DIADEMA', 'CASA GRANDE', 'PASSAGEM DÉBORA', '22', 'D:/projeto_interdisciplinar/pjr_petshop/bin/Debug/fotos_clientes/foto_cliente.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pet`
--

CREATE TABLE IF NOT EXISTS `pet` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome_pet` varchar(70) NOT NULL,
  `especie` varchar(50) NOT NULL,
  `raca` varchar(50) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `cpf_tutor` varchar(14) NOT NULL,
  `foto` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cpf_tutor` (`cpf_tutor`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Extraindo dados da tabela `pet`
--

INSERT INTO `pet` (`id`, `nome_pet`, `especie`, `raca`, `descricao`, `cpf_tutor`, `foto`) VALUES
(9, 'URSINHO', 'URSO', 'URSO-POLAR', 'URSÃO POLAR GIGANTE, ATERRORIZANTE', '11111111111', 'D:/projeto_interdisciplinar/pjr_petshop/bin/Debug/fotos_pets/urso_polar.jpg'),
(10, 'MASQUEICO', 'MACACO', 'MACACO', 'MOCACO', '11111111111', 'D:/projeto_interdisciplinar/pjr_petshop/bin/Debug/fotos_pets/macaco.png'),
(12, 'RAZANTE', 'CAVALO', 'CAVALO MARROM', 'CAVALO!', '11111111111', 'D:/projeto_interdisciplinar/pjr_petshop/bin/Debug/fotos_pets/cavalo.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `prodcomprado`
--

CREATE TABLE IF NOT EXISTS `prodcomprado` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_compra` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `nome_prod` varchar(80) NOT NULL,
  `preco_produto` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Extraindo dados da tabela `prodcomprado`
--

INSERT INTO `prodcomprado` (`id`, `id_compra`, `id_produto`, `nome_prod`, `preco_produto`) VALUES
(1, 1, 50, 'RACAO PARA GATOS FILHOTES', '69.00'),
(2, 1, 49, 'RACAO PREMIUM PARA CAES ADULTOS', '89.00'),
(3, 1, 62, 'PEITORAL CONFORTAVEL TAMANHO M', '39.00'),
(4, 2, 50, 'RACAO PARA GATOS FILHOTES', '69.00'),
(5, 2, 66, 'CASINHA DE MADEIRA TAMANHO G', '349.00'),
(6, 2, 70, 'CAMA ESTOFADA TAMANHO P', '79.00'),
(7, 2, 54, 'SHAMPOO PARA GATOS PELOS LONGOS', '29.00'),
(8, 3, 75, 'ARRANHADOR PARA GATOS PEQUENO', '59.00'),
(9, 3, 62, 'PEITORAL CONFORTAVEL TAMANHO M', '39.00'),
(10, 3, 55, 'SABONETE ANTISSÉPTICO PARA PETS', '19.00'),
(11, 4, 50, 'RACAO PARA GATOS FILHOTES', '69.00'),
(12, 4, 50, 'RACAO PARA GATOS FILHOTES', '69.00'),
(13, 5, 50, 'RACAO PARA GATOS FILHOTES', '69.00'),
(14, 5, 49, 'RACAO PREMIUM PARA CAES ADULTOS', '89.00'),
(15, 6, 51, 'PETISCO NATURAL PARA CAES', '19.00'),
(16, 6, 51, 'PETISCO NATURAL PARA CAES', '19.00'),
(17, 6, 52, 'PETISCO PARA GATOS SABOR PEIXE', '14.00'),
(18, 7, 50, 'RACAO PARA GATOS FILHOTES', '69.00'),
(19, 7, 50, 'RACAO PARA GATOS FILHOTES', '69.00'),
(20, 8, 50, 'RACAO PARA GATOS FILHOTES', '69.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE IF NOT EXISTS `produto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(70) NOT NULL,
  `tipo` varchar(30) NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  `estoque` int(11) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `preco` (`preco`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=79 ;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`id`, `nome`, `tipo`, `preco`, `estoque`, `descricao`) VALUES
(49, 'RACAO PREMIUM PARA CAES ADULTOS', 'ALIMENTACAO', '89.90', 48, 'RACAO DE ALTA QUALIDADE PARA CAES ADULTOS.'),
(50, 'RACAO PARA GATOS FILHOTES', 'ALIMENTAÇÃO', '69.90', 42, 'RACAO BALANCEADA PARA GATOS FILHOTES.'),
(51, 'PETISCO NATURAL PARA CAES', 'ALIMENTACAO', '19.90', 98, 'PETISCO SAUDAVEL E NATURAL PARA CAES.'),
(52, 'PETISCO PARA GATOS SABOR PEIXE', 'ALIMENTACAO', '14.90', 79, 'PETISCO SABOR PEIXE PARA GATOS.'),
(53, 'SHAMPOO NEUTRO PARA CAES', 'HIGIENE', '24.90', 60, 'SHAMPOO NEUTRO PARA HIGIENE DE CAES.'),
(54, 'SHAMPOO PARA GATOS PELOS LONGOS', 'HIGIENE', '29.90', 29, 'SHAMPOO ESPECIFICO PARA GATOS DE PELOS LONGOS.'),
(55, 'SABONETE ANTISSÉPTICO PARA PETS', 'HIGIENE', '19.50', 69, 'SABONETE ANTISSÉPTICO PARA CAES E GATOS.'),
(56, 'DESODORIZADOR AMBIENTE PET', 'HIGIENE', '22.90', 50, 'DESODORIZADOR PARA AMBIENTE COM PETS.'),
(57, 'COLEIRA TAMANHO P', 'ACESSORIO', '15.00', 150, 'COLEIRA AJUSTAVEL PARA PETS DE PEQUENO PORTE.'),
(58, 'COLEIRA TAMANHO M', 'ACESSORIO', '18.00', 120, 'COLEIRA AJUSTAVEL PARA PETS DE MEDIO PORTE.'),
(59, 'COLEIRA TAMANHO G', 'ACESSORIO', '20.00', 100, 'COLEIRA AJUSTAVEL PARA PETS DE GRANDE PORTE.'),
(60, 'GUIA DE NYLON RESISTENTE', 'ACESSORIO', '25.00', 90, 'GUIA DE NYLON PARA PASSEIO DE PETS.'),
(61, 'PEITORAL CONFORTAVEL TAMANHO P', 'ACESSORIO', '35.00', 80, 'PEITORAL CONFORTAVEL PARA PETS PEQUENOS.'),
(62, 'PEITORAL CONFORTAVEL TAMANHO M', 'ACESSORIO', '39.00', 68, 'PEITORAL CONFORTAVEL PARA PETS MEDIOS.'),
(63, 'PEITORAL CONFORTAVEL TAMANHO G', 'ACESSORIO', '45.00', 60, 'PEITORAL CONFORTAVEL PARA PETS GRANDES.'),
(64, 'CASINHA DE MADEIRA TAMANHO P', 'RECINTO', '249.90', 10, 'CASINHA DE MADEIRA PARA CAES PEQUENOS.'),
(65, 'CASINHA DE MADEIRA TAMANHO M', 'RECINTO', '299.90', 8, 'CASINHA DE MADEIRA PARA CAES MEDIOS.'),
(66, 'CASINHA DE MADEIRA TAMANHO G', 'RECINTO', '349.90', 4, 'CASINHA DE MADEIRA PARA CAES GRANDES.'),
(67, 'GAIOLA PARA HAMSTER', 'RECINTO', '99.90', 20, 'GAIOLA COMPLETA PARA HAMSTER.'),
(68, 'AQUARIO DE VIDRO 20L', 'RECINTO', '159.90', 15, 'AQUARIO DE VIDRO COM TAMPA E ILUMINACAO.'),
(69, 'AQUARIO DE VIDRO 50L', 'RECINTO', '299.90', 10, 'AQUARIO DE VIDRO MAIOR COM TAMPA E FILTRO.'),
(70, 'CAMA ESTOFADA TAMANHO P', 'RECINTO', '79.90', 24, 'CAMA CONFORTAVEL PARA PETS PEQUENOS.'),
(71, 'CAMA ESTOFADA TAMANHO M', 'RECINTO', '99.90', 20, 'CAMA CONFORTAVEL PARA PETS MEDIOS.'),
(72, 'CAMA ESTOFADA TAMANHO G', 'RECINTO', '129.90', 15, 'CAMA CONFORTAVEL PARA PETS GRANDES.'),
(73, 'BRINQUEDO DE BORRACHA OSSO', 'OUTROS', '9.90', 200, 'BRINQUEDO RESISTENTE EM FORMA DE OSSO.'),
(74, 'BOLA DE VINIL COLORIDA', 'OUTROS', '7.90', 250, 'BOLA DE VINIL MACIA E COLORIDA PARA PETS.'),
(75, 'ARRANHADOR PARA GATOS PEQUENO', 'OUTROS', '59.90', 29, 'ARRANHADOR COMPACTO PARA GATOS.'),
(76, 'ARRANHADOR PARA GATOS GRANDE', 'OUTROS', '129.90', 15, 'ARRANHADOR GRANDE COM DIVERSOS NIVEIS.'),
(77, 'PORTA-RACAO PLASTICO 10KG', 'OUTROS', '49.90', 20, 'RECIPIENTE PARA ARMAZENAR RACAO ATE 10KG.'),
(78, 'COMEDOURO DUPLO INOX', 'ALIMENTAÇÃO', '39.98', 70, 'COMEDOURO DUPLO EM ACO INOX PARA PETS.');

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `pet`
--
ALTER TABLE `pet`
  ADD CONSTRAINT `pet_ibfk_1` FOREIGN KEY (`cpf_tutor`) REFERENCES `cliente` (`cpf`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
