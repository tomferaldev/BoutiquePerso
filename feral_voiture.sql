-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 10 avr. 2025 à 15:01
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `feral_voiture`
--

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

DROP TABLE IF EXISTS `categories`;
CREATE TABLE IF NOT EXISTS `categories` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `categories`
--

INSERT INTO `categories` (`id`, `nom`) VALUES
(1, 'Sportive'),
(2, 'SUV'),
(3, 'Berline'),
(4, 'Cabriolet'),
(5, 'Electrique');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) NOT NULL,
  `prenom` varchar(20) NOT NULL,
  `rue` varchar(40) NOT NULL,
  `CP` varchar(5) NOT NULL,
  `ville` varchar(20) NOT NULL,
  `tel` varchar(15) NOT NULL,
  `email` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`id`, `nom`, `prenom`, `rue`, `CP`, `ville`, `tel`, `email`) VALUES
(1, 'feral', 'tom', '', '', '', '', ''),
(2, 'Dupont', 'Jean', '12 rue de la Paix', '75001', 'Paris', '0601020304', 'jean.dupont@email.com'),
(3, 'Martin', 'Sophie', '45 avenue des Champs', '69002', 'Lyon', '0611223344', 'sophie.martin@email.com'),
(4, 'Durand', 'Luc', '78 boulevard Haussmann', '13006', 'Marseille', '0622334455', 'luc.durand@email.com'),
(5, 'Bernard', 'Emma', '23 impasse des Lilas', '33000', 'Bordeaux', '0633445566', 'emma.bernard@email.com'),
(6, 'Morel', 'Hugo', '5 rue Victor Hugo', '59000', 'Lille', '0644556677', 'hugo.morel@email.com');

-- --------------------------------------------------------

--
-- Structure de la table `modeles`
--

DROP TABLE IF EXISTS `modeles`;
CREATE TABLE IF NOT EXISTS `modeles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `marque` varchar(50) NOT NULL,
  `nom_modele` varchar(50) NOT NULL,
  `annee` int NOT NULL,
  `prix` decimal(10,2) NOT NULL,
  `moteur` varchar(100) NOT NULL,
  `puissance` int NOT NULL,
  `image` varchar(255) DEFAULT NULL,
  `description` text,
  `categorie_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_categorie` (`categorie_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `modeles`
--

INSERT INTO `modeles` (`id`, `marque`, `nom_modele`, `annee`, `prix`, `moteur`, `puissance`, `image`, `description`, `categorie_id`) VALUES
(1, 'F-Luxury', 'HyperSport F1', 2025, '950000.00', 'V12 Bi-Turbo', 850, 'HSF1.jpg', 'Voiture de luxe ultra-performante avec un design futuriste et un moteur puissant.', 1),
(2, 'F-Luxury', 'NightShadow', 2025, '1500000.00', 'V12 Bi-Turbo', 1100, 'nightshadow.jpg', 'Voiture de sport de luxe avec un design futuriste, peinture noire brillante et portes en ciseaux. Équipée de phares LED tranchants et de jantes en alliage noir imposantes.', 1),
(3, 'F-Luxury', 'Shady', 2019, '500000.00', 'V8 NRJZ', 1100, 'shady.jpg', 'Voiture de sport avec une peinture atypique un rouge pour la chaleur et l\'énérgie que dégage cette voiture et la touche de rafraîchissement digne de la fraîcheur du plus haut sommet du monde', 1),
(4, 'F-Luxury', 'Spy', 2017, '5000000.00', 'W6 PureTech', 1100, 'spy.jpg', 'Voiture rétro rapellent sa légendaire précédente la Coquette avec un nouveau design et a la pointe de la technologie', 3);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `id` int NOT NULL AUTO_INCREMENT,
  `login` varchar(20) NOT NULL,
  `passe` varchar(1000) NOT NULL,
  `email` varchar(30) NOT NULL,
  `type` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `login`, `passe`, `email`, `type`) VALUES
(1, 'feral', '3c95065b67cded6f1fe70165d57a45a8ae9a15e4', 'nevousregardepas@gmail.com', 'admin'),
(2, 'utilisateur', 'd3961aa89e29d15cfb52600dc0bd51548fc538a4', 'unutilisateur@gmail.com', 'utilisateur'),
(3, 'Martin', '54669547a225ff20cba8', 'martin@gmail.com', 'admin'),
(9, 'marc', 'd33c80bc45d65303e33ca83108a9952b745af9ef', 'marc@gmail.com', 'client');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
