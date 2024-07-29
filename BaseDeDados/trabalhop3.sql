-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24-Maio-2024 às 17:51
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
-- Banco de dados: `trabalhop3`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `league`
--

CREATE TABLE `league` (
  `leagueID` int(11) NOT NULL,
  `leagueName` varchar(255) NOT NULL,
  `leagueCountry` varchar(255) NOT NULL,
  `leagueMaxCap` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `league`
--

INSERT INTO `league` (`leagueID`, `leagueName`, `leagueCountry`, `leagueMaxCap`) VALUES
(1, 'Liga Portugal', 'Portugal', 18),
(2, 'Premier League', 'England', 20),
(3, 'Bundesliga', 'Germany', 18);

-- --------------------------------------------------------

--
-- Estrutura da tabela `team`
--

CREATE TABLE `team` (
  `teamID` int(11) NOT NULL,
  `teamName` varchar(255) NOT NULL,
  `FkLeagueID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `team`
--

INSERT INTO `team` (`teamID`, `teamName`, `FkLeagueID`) VALUES
(1, 'Sport Lisboa e Benfica', 1),
(2, 'Sporting Clube de Portugal', 1),
(3, 'Ballspiel-Verein Borussia 1909 e. V. Dortmund', 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `user`
--

CREATE TABLE `user` (
  `userID` int(11) NOT NULL,
  `userName` varchar(255) NOT NULL,
  `userPassword` varchar(255) NOT NULL,
  `userRole` varchar(255) NOT NULL DEFAULT 'Normal'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `user`
--

INSERT INTO `user` (`userID`, `userName`, `userPassword`, `userRole`) VALUES
(1, 'Admin', '123456!', 'Admin'),
(2, 'Castro', '12345!', 'Normal');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `league`
--
ALTER TABLE `league`
  ADD PRIMARY KEY (`leagueID`);

--
-- Índices para tabela `team`
--
ALTER TABLE `team`
  ADD PRIMARY KEY (`teamID`),
  ADD KEY `FkLeagueID` (`FkLeagueID`);

--
-- Índices para tabela `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `league`
--
ALTER TABLE `league`
  MODIFY `leagueID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `team`
--
ALTER TABLE `team`
  MODIFY `teamID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `user`
--
ALTER TABLE `user`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `team`
--
ALTER TABLE `team`
  ADD CONSTRAINT `team_ibfk_1` FOREIGN KEY (`FkLeagueID`) REFERENCES `league` (`leagueID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
