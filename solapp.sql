-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 09, 2024 at 04:27 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `solapp`
--

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `dateDebut` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`id`, `nom`, `dateDebut`) VALUES
(1, 'Course de printemps', '2024-05-01'),
(2, 'Course d\'été', '2024-08-15'),
(3, 'Course d\'automne', '2024-10-05'),
(4, 'Course d\'hiver', '2024-12-20'),
(5, 'Course de nouvelle année', '2025-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `course_epreuve`
--

CREATE TABLE `course_epreuve` (
  `id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL,
  `epreuve_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `course_epreuve`
--

INSERT INTO `course_epreuve` (`id`, `course_id`, `epreuve_id`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 2, 4),
(5, 3, 5);

-- --------------------------------------------------------

--
-- Table structure for table `course_voilier`
--

CREATE TABLE `course_voilier` (
  `id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL,
  `voilier_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `course_voilier`
--

INSERT INTO `course_voilier` (`id`, `course_id`, `voilier_id`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 2, 4),
(5, 3, 5);

-- --------------------------------------------------------

--
-- Table structure for table `entreprise`
--

CREATE TABLE `entreprise` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `contact` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `entreprise`
--

INSERT INTO `entreprise` (`id`, `nom`, `adresse`, `contact`) VALUES
(1, 'Entreprise A', '123 Rue A, Ville A', 'contactA@example.com'),
(2, 'Entreprise B', '456 Rue B, Ville B', 'contactB@example.com'),
(3, 'Entreprise C', '789 Rue C, Ville C', 'contactC@example.com'),
(4, 'Entreprise D', '101 Rue D, Ville D', 'contactD@example.com'),
(5, 'Entreprise E', '112 Rue E, Ville E', 'contactE@example.com');

-- --------------------------------------------------------

--
-- Table structure for table `epreuve`
--

CREATE TABLE `epreuve` (
  `id` int(11) NOT NULL,
  `libelle` varchar(255) NOT NULL,
  `type` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `epreuve`
--

INSERT INTO `epreuve` (`id`, `libelle`, `type`) VALUES
(1, 'Epreuve de vitesse', 1),
(2, 'Epreuve d\'endurance', 2),
(3, 'Epreuve de navigation', 3),
(4, 'Epreuve de manœuvre', 4),
(5, 'Epreuve de sécurité', 5);

-- --------------------------------------------------------

--
-- Table structure for table `penalite`
--

CREATE TABLE `penalite` (
  `id` int(11) NOT NULL,
  `type_penalite_id` int(11) NOT NULL,
  `heure` time NOT NULL,
  `latitude` double NOT NULL,
  `longitude` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `penalite`
--

INSERT INTO `penalite` (`id`, `type_penalite_id`, `heure`, `latitude`, `longitude`) VALUES
(1, 1, '12:30:00', 48.8566, 2.3522),
(2, 2, '14:45:00', 51.5074, -0.1278),
(3, 3, '09:15:00', 40.7128, -74.006),
(4, 4, '16:00:00', 35.6895, 139.6917),
(5, 5, '10:20:00', -33.8688, 151.2093);

-- --------------------------------------------------------

--
-- Table structure for table `personne`
--

CREATE TABLE `personne` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `personne`
--

INSERT INTO `personne` (`id`, `nom`, `prenom`, `role`) VALUES
(1, 'Dupont', 'Jean', 'Capitaine'),
(2, 'Martin', 'Luc', 'Navigateur'),
(3, 'Leroy', 'Paul', 'Mécanicien'),
(4, 'Durand', 'Pierre', 'Voilier'),
(5, 'Simon', 'Marie', 'Tacticien');

-- --------------------------------------------------------

--
-- Table structure for table `type_penalite`
--

CREATE TABLE `type_penalite` (
  `id` int(11) NOT NULL,
  `code` varchar(255) NOT NULL,
  `duree` time NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `type_penalite`
--

INSERT INTO `type_penalite` (`id`, `code`, `duree`, `description`) VALUES
(1, 'TP001', '00:05:00', 'Pénalité mineure'),
(2, 'TP002', '00:10:00', 'Pénalité modérée'),
(3, 'TP003', '00:20:00', 'Pénalité grave'),
(4, 'TP004', '00:30:00', 'Pénalité très grave'),
(5, 'TP005', '01:00:00', 'Pénalité éliminatoire');

-- --------------------------------------------------------

--
-- Table structure for table `voilier`
--

CREATE TABLE `voilier` (
  `id` int(11) NOT NULL,
  `code` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `voilier`
--

INSERT INTO `voilier` (`id`, `code`) VALUES
(1, 'VA102SETE'),
(2, 'VB203MARSEILLE'),
(3, 'VC304NICE'),
(4, 'VD405BORDEAUX'),
(5, 'VE506PARIS');

-- --------------------------------------------------------

--
-- Table structure for table `voilier_entreprise`
--

CREATE TABLE `voilier_entreprise` (
  `id` int(11) NOT NULL,
  `voilier_id` int(11) NOT NULL,
  `entreprise_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `voilier_entreprise`
--

INSERT INTO `voilier_entreprise` (`id`, `voilier_id`, `entreprise_id`) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);

-- --------------------------------------------------------

--
-- Table structure for table `voilier_inscrit`
--

CREATE TABLE `voilier_inscrit` (
  `id` int(11) NOT NULL,
  `voilier_id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `voilier_inscrit`
--

INSERT INTO `voilier_inscrit` (`id`, `voilier_id`, `course_id`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 2),
(4, 4, 2),
(5, 5, 3);

-- --------------------------------------------------------

--
-- Table structure for table `voilier_personne`
--

CREATE TABLE `voilier_personne` (
  `id` int(11) NOT NULL,
  `voilier_id` int(11) NOT NULL,
  `personne_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `voilier_personne`
--

INSERT INTO `voilier_personne` (`id`, `voilier_id`, `personne_id`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 3, 4),
(5, 4, 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `course_epreuve`
--
ALTER TABLE `course_epreuve`
  ADD PRIMARY KEY (`id`),
  ADD KEY `course_id` (`course_id`),
  ADD KEY `epreuve_id` (`epreuve_id`);

--
-- Indexes for table `course_voilier`
--
ALTER TABLE `course_voilier`
  ADD PRIMARY KEY (`id`),
  ADD KEY `course_id` (`course_id`),
  ADD KEY `voilier_id` (`voilier_id`);

--
-- Indexes for table `entreprise`
--
ALTER TABLE `entreprise`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `epreuve`
--
ALTER TABLE `epreuve`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penalite`
--
ALTER TABLE `penalite`
  ADD PRIMARY KEY (`id`),
  ADD KEY `type_penalite_id` (`type_penalite_id`);

--
-- Indexes for table `personne`
--
ALTER TABLE `personne`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `type_penalite`
--
ALTER TABLE `type_penalite`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `voilier`
--
ALTER TABLE `voilier`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `voilier_entreprise`
--
ALTER TABLE `voilier_entreprise`
  ADD PRIMARY KEY (`id`),
  ADD KEY `voilier_id` (`voilier_id`),
  ADD KEY `entreprise_id` (`entreprise_id`);

--
-- Indexes for table `voilier_inscrit`
--
ALTER TABLE `voilier_inscrit`
  ADD PRIMARY KEY (`id`),
  ADD KEY `voilier_id` (`voilier_id`),
  ADD KEY `course_id` (`course_id`);

--
-- Indexes for table `voilier_personne`
--
ALTER TABLE `voilier_personne`
  ADD PRIMARY KEY (`id`),
  ADD KEY `voilier_id` (`voilier_id`),
  ADD KEY `personne_id` (`personne_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `course_epreuve`
--
ALTER TABLE `course_epreuve`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `course_voilier`
--
ALTER TABLE `course_voilier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `entreprise`
--
ALTER TABLE `entreprise`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `epreuve`
--
ALTER TABLE `epreuve`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `penalite`
--
ALTER TABLE `penalite`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `personne`
--
ALTER TABLE `personne`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `type_penalite`
--
ALTER TABLE `type_penalite`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `voilier`
--
ALTER TABLE `voilier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `voilier_entreprise`
--
ALTER TABLE `voilier_entreprise`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `voilier_inscrit`
--
ALTER TABLE `voilier_inscrit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `voilier_personne`
--
ALTER TABLE `voilier_personne`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `course_epreuve`
--
ALTER TABLE `course_epreuve`
  ADD CONSTRAINT `course_epreuve_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `course` (`id`),
  ADD CONSTRAINT `course_epreuve_ibfk_2` FOREIGN KEY (`epreuve_id`) REFERENCES `epreuve` (`id`);

--
-- Constraints for table `course_voilier`
--
ALTER TABLE `course_voilier`
  ADD CONSTRAINT `course_voilier_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `course` (`id`),
  ADD CONSTRAINT `course_voilier_ibfk_2` FOREIGN KEY (`voilier_id`) REFERENCES `voilier` (`id`);

--
-- Constraints for table `penalite`
--
ALTER TABLE `penalite`
  ADD CONSTRAINT `penalite_ibfk_1` FOREIGN KEY (`type_penalite_id`) REFERENCES `type_penalite` (`id`);

--
-- Constraints for table `voilier_entreprise`
--
ALTER TABLE `voilier_entreprise`
  ADD CONSTRAINT `voilier_entreprise_ibfk_1` FOREIGN KEY (`voilier_id`) REFERENCES `voilier` (`id`),
  ADD CONSTRAINT `voilier_entreprise_ibfk_2` FOREIGN KEY (`entreprise_id`) REFERENCES `entreprise` (`id`);

--
-- Constraints for table `voilier_inscrit`
--
ALTER TABLE `voilier_inscrit`
  ADD CONSTRAINT `voilier_inscrit_ibfk_1` FOREIGN KEY (`voilier_id`) REFERENCES `voilier` (`id`),
  ADD CONSTRAINT `voilier_inscrit_ibfk_2` FOREIGN KEY (`course_id`) REFERENCES `course` (`id`);

--
-- Constraints for table `voilier_personne`
--
ALTER TABLE `voilier_personne`
  ADD CONSTRAINT `voilier_personne_ibfk_1` FOREIGN KEY (`voilier_id`) REFERENCES `voilier` (`id`),
  ADD CONSTRAINT `voilier_personne_ibfk_2` FOREIGN KEY (`personne_id`) REFERENCES `personne` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
