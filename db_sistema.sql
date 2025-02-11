-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11/02/2025 às 15:30
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_sistema`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_carros`
--

CREATE TABLE `tb_carros` (
  `id` int(11) NOT NULL,
  `Proprietario` varchar(100) NOT NULL,
  `Telefone` varchar(9) NOT NULL,
  `Cpf` int(12) NOT NULL,
  `Placa` varchar(7) NOT NULL,
  `Modelo` int(17) NOT NULL,
  `Ano` int(4) NOT NULL,
  `Chassi` varchar(17) NOT NULL,
  `Cor` varchar(50) NOT NULL,
  `Marca` varchar(50) NOT NULL,
  `Valor` varchar(8) NOT NULL,
  `Acessorio` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_carros`
--

INSERT INTO `tb_carros` (`id`, `Proprietario`, `Telefone`, `Cpf`, `Placa`, `Modelo`, `Ano`, `Chassi`, `Cor`, `Marca`, `Valor`, `Acessorio`) VALUES
(1, 'marcia', '0', 378228, '54s5s', 0, 2020, 'f5f4d54f54d54f5d4', 'branco', 'hyundai', '0', 'teste'),
(2, 'hana', '(11) 5686', 229469, 'd4sf54d', 0, 2020, 'fdsf546d5f6sd56d5', 'preto', 'hyundai', 'R$454.54', 'teste'),
(3, 'Cecilia', '(19) 9556', 0, 'asd67', 0, 2013, '65g65gfd65gfd65f6', 'preto', 'chevrolet', 'R$210.56', 'ar condicionado e porta copos'),
(4, 'Cecilia', '(19) 4454', 0, 'akjs', 0, 2013, 'fdssd5g65f65f54gg', 'preto', 'chevrolet', 'R$455.44', 'ar condicionado');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_clientes`
--

CREATE TABLE `tb_clientes` (
  `Id_Cliente` int(11) NOT NULL,
  `NomeCompleto` varchar(150) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Cep` varchar(9) NOT NULL,
  `Numero` varchar(5) NOT NULL,
  `Telefone` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_clientes`
--

INSERT INTO `tb_clientes` (`Id_Cliente`, `NomeCompleto`, `Cpf`, `Email`, `Cep`, `Numero`, `Telefone`) VALUES
(1, 'Vagner Lourenço', '1813458926', 'ilsdhfjklsfhd@klshdfklshdf', '654645', '6546', '65464'),
(2, 'System.Windows.Forms.TextBox, Text: asdasdasd', 'System.Windows', 'System.Windows.Forms.TextBox, Text: asdasd', 'System.Wi', 'Syste', 'System.Windows'),
(4, 'sdasd', '279.151.838-00', '1wsadd', '23131-231', '12312', '(12) 31231-231'),
(5, 'dsfsdfsdf', '279.151.838-00', 'sdfsdf', '23423-423', ' 234', '(32) 42342-342');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_carros`
--
ALTER TABLE `tb_carros`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  ADD PRIMARY KEY (`Id_Cliente`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_carros`
--
ALTER TABLE `tb_carros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  MODIFY `Id_Cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
