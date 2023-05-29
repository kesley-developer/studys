-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16-Dez-2022 às 01:18
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
-- Banco de dados: `hospital`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_medico`
--

CREATE TABLE `tb_medico` (
  `id_medico` int(11) NOT NULL,
  `nome_medico` varchar(25) NOT NULL,
  `especialidade` varchar(20) NOT NULL,
  `crm` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_medico`
--

INSERT INTO `tb_medico` (`id_medico`, `nome_medico`, `especialidade`, `crm`) VALUES
(1, 'Mauro Souza', 'Cardiologia', 512350),
(2, 'Isabela Queiroz', 'Oftalmologia', 458759),
(3, 'Junior Almeida', 'Acunputura', 785112),
(4, 'Marly Silva', 'Alergia', 312557),
(5, 'Beatriz Silva', 'Pediatria', 420110),
(6, 'Takeda Shiono', 'Ortopedia', 778104),
(7, 'Augusto Fernandez', 'Infectologia', 202479),
(8, 'Lays Ribeiro', 'Dermatologia', 224489),
(9, 'Luisa Santos', 'Clínica Médica', 730154),
(10, 'Roberta Alves', 'Nutrição', 952103),
(11, 'Gisele Duques', 'Psicologia', 315400),
(12, 'Renato Tevez', 'Cirurgia', 543120),
(13, 'Katia Navaro', 'Geriatria', 432104),
(14, 'Lucas Aparecido', 'Psiquiatria', 114960),
(15, 'Raul Lima', 'Cardiologia', 210035),
(16, 'Leonardo Costa', 'Oftalmologia', 116478),
(17, 'Barbara Cruz', 'Alergia', 123970),
(18, 'Miriam Alberta', 'Pediatria', 300109),
(19, 'Kaue Moura', 'Ortopedia', 556413),
(20, 'Alan Ricardo', 'Infectologia', 901560),
(21, 'Denis Marcondes', 'Dermatologia', 143000),
(22, 'Cimara Tavarez', 'Clínica Médica', 113468),
(23, 'Sara Alexia', 'Psicologia', 731005),
(24, 'Natalia Tureta', 'Cirurgia', 484234),
(25, 'Luques Pierro', 'Geriatria', 951761),
(26, 'Yan Andrade', 'Psiquiatria', 984320),
(27, 'Antonia Laureta', 'Oftalmologia', 330949),
(28, 'Shen Nakamura', 'Pediatria', 232099),
(29, 'Velma Luz', 'Dermatologia', 886910),
(30, 'Éder Bauler', 'Clínica Médica', 809714),
(31, 'Wellington Sauro', 'Cirurgia', 410795),
(32, 'Carlos Daniel', 'Geriatria', 987101),
(33, 'Henrique Peixote', 'Pediatria', 301846),
(34, 'Kenzo Tema', 'Cirurgia', 310094),
(35, 'Oliver Deziderio', 'Geriatria', 554910),
(36, 'David Junior', 'Cirurgia', 349730),
(37, 'John Lindegard', 'Cirurgia', 975501);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_paciente`
--

CREATE TABLE `tb_paciente` (
  `id_paciente` int(11) NOT NULL,
  `nome_paciente` varchar(30) NOT NULL,
  `idade` int(3) NOT NULL,
  `genero` varchar(1) NOT NULL,
  `endereco` varchar(30) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `bairro` varchar(15) NOT NULL,
  `celular` varchar(17) NOT NULL,
  `estado_civil` varchar(10) NOT NULL,
  `rg` varchar(12) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `numero_cartao` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_paciente`
--

INSERT INTO `tb_paciente` (`id_paciente`, `nome_paciente`, `idade`, `genero`, `endereco`, `cep`, `bairro`, `celular`, `estado_civil`, `rg`, `cpf`, `numero_cartao`) VALUES
(1, 'Marcos Roberto', 42, 'M', 'Rua Vila Velha, 448', '08210-610', 'Guarulhos', '(11)91874-8124', 'Solteiro', '41.110.250-8', '197.001.387-02', '7943487920-8413'),
(2, 'Luisa Santos', 21, 'F', 'Rua Augusto Moraes, 110', '08645-450', 'Esperança', '(11)92187-9100', 'Solteira', '27.839.055-7', '329.041.105-56', '32489741601-4860'),
(3, 'Thiago Gonzaga', 30, 'M', 'Rua Santos Silveira, 84', '03440-870', 'Itaquera', '(11)94875-1034', 'Casado', '84.399.047-', '841.310.018-12', '06780014553-7864'),
(4, 'Maria Barreto', 50, 'F', 'Av. Farias Siqueira', '01840-840', 'Mooca', '(11)96541-8101', 'Casada', '35.403.630-4', '24.310.731-30', '64012384497-0412'),
(5, 'Rogério Domingos', 60, 'M', 'Rua Das Trincheiras, 520', '04180-450', 'Lapa', '(11)94810-5510', 'Casado', '59.090.200-9', '247.310.458-68', '64221364850-9410'),
(6, 'Silvana Loreta', 38, 'F', 'Estrada Dos Vigilantes, 202', '08971-510', 'Estudantes', '(11)90214-8451', 'Solteira', '71.851.601-6', '150.419.963-40', '31587542120-4856'),
(7, 'Neide Roberta', 45, 'F', 'Rua Dominicanos Lovrero, 55', '08130-410', 'Liberdade', '(11)90489-1249', 'Casada', '84.781.250-9', '808.487.612-21', '70765125519-1034'),
(8, 'José Siqueira', 29, 'M', 'Rua Rosas Brancas, 69', '08455-803', 'São Miguel', '(11)97031-9401', 'Solteiro', '30.648.120-9', '115.249.693-18', '38910248910-8897'),
(9, 'Cristiane Silva', 30, 'M', 'Av. Dos Laranjais', '08341-900', 'Vila Matilde', '(11)97401-4480', 'Casada', '33.498.025-9', '879.340.981-31', '29412648091-6841'),
(10, 'Giovanni Mario', 18, 'M', 'Rua Betânia De Paula, 8', '03108-101', 'Penha', '(11)91507-8799', 'Solteiro', '44.212.983-1', '881.303.659-32', '87954103259-4802');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_medico`
--
ALTER TABLE `tb_medico`
  ADD UNIQUE KEY `id_medico` (`id_medico`),
  ADD UNIQUE KEY `crm` (`crm`);

--
-- Índices para tabela `tb_paciente`
--
ALTER TABLE `tb_paciente`
  ADD PRIMARY KEY (`id_paciente`),
  ADD UNIQUE KEY `rg` (`rg`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `numero_cartao` (`numero_cartao`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_medico`
--
ALTER TABLE `tb_medico`
  MODIFY `id_medico` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT de tabela `tb_paciente`
--
ALTER TABLE `tb_paciente`
  MODIFY `id_paciente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
