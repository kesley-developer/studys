-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16-Dez-2022 às 01:25
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `empresa`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome_do_cliente` varchar(30) NOT NULL,
  `idade` int(3) NOT NULL,
  `genero` varchar(1) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `celular` varchar(18) NOT NULL,
  `estado_civil` varchar(12) NOT NULL,
  `rg` varchar(13) NOT NULL,
  `cpf` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`id_cliente`, `nome_do_cliente`, `idade`, `genero`, `endereco`, `cep`, `bairro`, `celular`, `estado_civil`, `rg`, `cpf`) VALUES
(1, 'Eliana Ribeiro', 21, 'F', 'Avenida Brasil, 1500', '03600-010', 'Penha', '(11)99700-9104', 'Solteira', '48.993.520-5', '897.031.563-21'),
(2, 'Miguel Silva', 30, 'M', 'Rua de contorno, 55', '08200-130', 'Itaquera', '(11)98161-8302', 'Casado', '17.536.619-6', '118.143.116-09'),
(3, 'Robson Tomaz', 25, 'M', 'Trav. Esperança, 700', '03600-020', 'Penha', '(11)97003-7631', 'Solteiro', '41.526.925-8', '107.938.036-16'),
(4, 'Sidney Sheldon', 40, 'M', 'Rua Santa Efigênia, 21', '01000-250', 'Sé', '(11)96155-6236', 'Casado', '32.294.863-0', '114.340.396-76'),
(5, 'Maria Rodrigues', 50, 'F', 'Avenida Iguaçu, 3478', '08100-500', 'Itaim Paulista', '(11)92134-9876', 'Casada', '34.749.966-1', '340.211.298-12'),
(6, 'Victor Melo', 20, 'M', 'Avenida Marechal Tio, 1200', '08000-200', 'São Miguel', '(11)98765-5432', 'Solteiro', '32.566.578-3', '648.587.061-10'),
(7, 'Anderson Simas', 35, 'M', 'Trav. Ponte Pequena, 100', '01000-283', 'Sé', '(11)95432-1110', 'Casado', '30.903.005-5', '942.643.468-80'),
(8, 'Jeferson Gonçalves', 18, 'M', 'Rua Iguape Fonseca, 90', '05400-001', 'Pinheiros', '(11)91980-1221', 'Solteiro', '26.366.228-7', '116.923.356-22'),
(9, 'Paula França', 22, 'F', 'Avenida Santos Dumond, 1375', '05000-123', 'Lapa', '(11)94377-1313', 'Solteira', '41.884.404-5', '120.245.581-65'),
(10, 'Fátima Santos', 28, 'F', 'Rua Silvério Fontes, 44', '08000-300', 'São Miguel', '(11)99751-1514', 'Casada', '40.956.561-1', '115.964.776-36'),
(11, 'Ana Carolina Santos', 47, 'F', 'Rua Álvoro Mendonça, 200', '08200-170', 'Itaquera', '(11)97618-2855', 'Casada', '41.795.250-8', '110.649.926-33');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_fornecedor`
--

CREATE TABLE `tb_fornecedor` (
  `id_fornecedor` int(11) NOT NULL,
  `nome_empresa` varchar(20) NOT NULL,
  `tipo_fornecedor` varchar(20) NOT NULL,
  `nome_representante` varchar(15) NOT NULL,
  `cargo_representante` varchar(15) NOT NULL,
  `celular_representante` varchar(17) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_fornecedor`
--

INSERT INTO `tb_fornecedor` (`id_fornecedor`, `nome_empresa`, `tipo_fornecedor`, `nome_representante`, `cargo_representante`, `celular_representante`) VALUES
(2, 'Mais Água', 'Água', 'Rafael', 'Compras', '(11)93618-2855'),
(3, 'Ecolimp', 'Limpeza', 'Simone', 'Assistente', '(11)91132-1111'),
(4, 'WebTec', 'Informática', 'André', 'Analista', '(11)98155-7236'),
(5, 'Levesa', 'Água', 'Fábio', 'Gestor', '(11)97261-2302'),
(6, 'MegaMix', 'Informática', 'Marta', 'Vendas', '(11)99400-5103'),
(7, 'Barreto', 'Bebidas', 'Marcos', 'Administrador', '(11)93003-1631'),
(8, 'Futura', 'Eletrônicos', 'Paulo', 'Assistente', '(11)92244-6876'),
(9, 'MegaData', 'Informática', 'Neide', 'Compras', '(11)96980-2421'),
(10, 'Vinny', 'Doces', 'Vanessa', 'Analista', '(11)93377-4513'),
(11, 'Boi do Povo', 'Carnes', 'Gabriel', 'Gestor', '(11)98631-2932'),
(12, 'Doce Preço', 'Pâes', 'Rosa', 'Vendas', '(11)97751-7514'),
(13, 'Frescarini', 'Massas', 'Ana', 'Compras', '(11)99369-3978'),
(14, 'Jandaia', 'Escritório', 'Miguel', 'Administrador', '(11)91698-4239'),
(15, 'Select', 'Descartavéis', 'Ricardo', 'Compras', '(11)92601-9570');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `cpf_2` (`cpf`),
  ADD UNIQUE KEY `rg` (`rg`);

--
-- Índices para tabela `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  ADD PRIMARY KEY (`id_fornecedor`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  MODIFY `id_fornecedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
