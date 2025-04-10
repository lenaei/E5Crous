Le CROUS a mis en place une application de bureau destinée à ses salariés, qui permet à ces derniers de s'authentifier et d'accéder à une plateforme spécialisée dans la gestion des étudiants et des logements.

Les principales fonctionnalités de l'application incluent la connexion, la déconnexion, le référencement de nouveaux appartements, leur modification et suppression, l'enregistrement de nouveaux étudiants, leur modification et suppression, ainsi que l'affichage du logement associé à chaque étudiant.

L'application est conçue selon l'architecture MVC (Modèles, Vues, Contrôleurs). Voici la procédure d'installation :

Installez un environnement de développement local tel que WampServer, XAMPP, ou un équivalent.

Importez la base de données 'crous' en utilisant le fichier SQL 'crous.sql' localement.

Accédez à l'application en ouvrant le fichier solution (.sln) nommé 'crous.sln' présent dans le répertoire du projet.

Un compte exemple vous est fourni pour les tests :

Email : ahamadiisaie@gmail.com

Mot de passe : siojjr

Rôles et Permissions :

Étant une application destinée uniquement aux salariés du CROUS, les permissions sont identiques pour tous. Les utilisateurs peuvent se connecter/déconnecter, référencer un nouveau logement, le modifier ou le supprimer, enregistrer un nouvel étudiant, le modifier ou le supprimer, et afficher l'appartement associé à un étudiant.

Structure de la base de données : https://imgur.com/a/08f9704