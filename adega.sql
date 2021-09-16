-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16-Set-2021 às 02:45
-- Versão do servidor: 10.4.20-MariaDB
-- versão do PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `adega`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `vinho`
--

CREATE TABLE `vinho` (
  `idVinho` int(11) NOT NULL,
  `nomeVinho` varchar(50) CHARACTER SET utf8 NOT NULL,
  `categoriaVinho` varchar(50) NOT NULL,
  `descricaoVinho` text NOT NULL,
  `anoVinho` int(4) NOT NULL,
  `ativoVinho` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `vinho`
--

INSERT INTO `vinho` (`idVinho`, `nomeVinho`, `categoriaVinho`, `descricaoVinho`, `anoVinho`, `ativoVinho`) VALUES
(1, 'Decanto ', 'Suave', 'Produzido com uva Verde.', 1994, 1),
(2, 'JotaP', 'Branco', 'Produzido na Serra Gaúcha.', 1999, 1),
(3, 'Veuve Clicquot', 'Tannat', 'VinhoProduzido a base de laranja.', 2002, 1),
(5, 'ADW', 'Gewurztraminer', 'Produzido com uvas Brasileiras.', 2012, 1),
(6, 'Red3', 'Pinot Noir', 'Produzido com Uvas Vermelhas.', 2005, 1),
(8, 'La Viena ', 'Tinto ', 'Produção Artezanal.', 2008, 1),
(9, 'Arturito', 'Tinto ', 'Inportado.', 2000, 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `vinho`
--
ALTER TABLE `vinho`
  ADD PRIMARY KEY (`idVinho`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `vinho`
--
ALTER TABLE `vinho`
  MODIFY `idVinho` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
