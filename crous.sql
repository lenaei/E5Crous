-- Structure de la table `appartement`
DROP TABLE IF EXISTS `appartement`;
CREATE TABLE IF NOT EXISTS `appartement` (
  `id_appartement` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) NOT NULL,
  `description` text,
  `adresse` varchar(255) NOT NULL,
  `code_postal` char(5) NOT NULL,
  `ville` varchar(255) NOT NULL,
  `superficie` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id_appartement`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Structure de la table `etudiant`
DROP TABLE IF EXISTS `etudiant`;
CREATE TABLE IF NOT EXISTS `etudiant` (
  `id_etudiant` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `date_naissance` date NOT NULL,
  `email` varchar(255) NOT NULL,
  PRIMARY KEY (`id_etudiant`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Structure de la table `locataire`
DROP TABLE IF EXISTS `locataire`;
CREATE TABLE IF NOT EXISTS `locataire` (
  `id_locataire` int NOT NULL AUTO_INCREMENT,
  `id_etudiant` int NOT NULL,
  `id_appartement` int NOT NULL,
  `date_emmenagement` date NOT NULL,
  `date_depart` date DEFAULT NULL,
  PRIMARY KEY (`id_locataire`),
  UNIQUE KEY `id_etudiant` (`id_etudiant`),
  UNIQUE KEY `id_appartement` (`id_appartement`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Structure de la table `utilisateurs`
DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `id_utilisateur` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id_utilisateur`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Contraintes pour la table `locataire`
ALTER TABLE `locataire`
  ADD CONSTRAINT `locataire_ibfk_1` FOREIGN KEY (`id_etudiant`) REFERENCES `etudiant` (`id_etudiant`) ON DELETE CASCADE,
  ADD CONSTRAINT `locataire_ibfk_2` FOREIGN KEY (`id_appartement`) REFERENCES `appartement` (`id_appartement`) ON DELETE CASCADE;

-- Déchargement des données de la table `appartement`
INSERT INTO `appartement` (`id_appartement`, `libelle`, `description`, `adresse`, `code_postal`, `ville`, `superficie`) VALUES
(1, 'Studio Lumineux', 'Un beau studio lumineux et bien situé.', '123 Rue de Paris', '75001', 'Paris', 35.00),
(2, 'Appartement 2 pièces', 'Appartement spacieux avec balcon.', '45 Rue des Roses', '33000', 'Bordeaux', 50.00),
(6, 'T3 a BANDRELE', 'T3 full meublé à passam', '336 RUE FRANGIPANIER', '97660', 'BANDRELE', 50.00);

-- Déchargement des données de la table `etudiant`
INSERT INTO `etudiant` (`id_etudiant`, `nom`, `prenom`, `date_naissance`, `email`) VALUES
(1, 'Ahamadi', 'Isaie-Dean, Nawfel', '2003-12-29', 'ahamadiisaie@gmail.com'),
(6, 'Ahm', 'Isaie', '2003-12-29', 'AhmIsaie@gmail.com');

-- Déchargement des données de la table `locataire`
INSERT INTO `locataire` (`id_locataire`, `id_etudiant`, `id_appartement`, `date_emmenagement`, `date_depart`) VALUES
(1, 1, 2, '2025-04-07', NULL);

-- Déchargement des données de la table `utilisateurs`
INSERT INTO `utilisateurs` (`id_utilisateur`, `nom`, `prenom`, `email`, `password`) VALUES
(1, 'AHAMADI', 'Isaie-Dean, Nawfel', 'ahamadiisaie@gmail.com', 'siojjr');
