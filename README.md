# .NET
Appilications réalisées dans le cadre d'une formation, elles n'ont pas vocation à plagier les organismes cités.

MaJ : 20/03/2021

Gest_Med

- Application WPF conçue pour des créations de Clients/patients et de Soignants/médecins afin de gérer des prises de rendez-vous (à l'image de ce que fait Doctolib)
- Conception des Classes Patient, Medecin, RDV et Spécialité avec leurs attributs mais également leurs méthodes qui feront appel à une classe supplémentaire appelée 
Database dans laquelle sont contenues toutes les méthodes d'intérrogation de la Base de données.
- Menu + 6 formulaires (gestion des patients, gestion des médecins, gestion des rendez vous et ensuite 3 formulaire pour la consultation des rendez-vous)
- Gestion des Affichages des 3 formulaires de consultation avec des datagrid.


MVVMDoctolib

- Avec l'avancée du cours, j'ai décidé de recréer l'application Gest_Med mais cette fois-ci en utilisant le pattern MVVM.
- Les informations affichées sont gérées par des ListView cette fois-ci
- Même principe de gestion des patients, médecins et rendez-vous.
- L'appli intérroge la même Base de données que Gest_Med
- Je n'ai pas encore crée de menu pour celle-ci, alors pour accéder au formulaire que vous voulez il faut changer le point d'entrée de l'application dans le 
App.xaml comme suit   "StartupUri="View/GestionRDV.xaml" ou " StartupUri="View/GestionMedecin.xaml" ou " StartupUri="View/GestionMedecin.xaml"

ASPDoctolib

- Avec l'apprentissage de l'ASP.NET, j'ai crée cette appli ASP pour créer un début de simili Doctolib.
- L'application utilise les mêmes classes que précédemment mais les méthodes de la classe Database sont légèrement différentes.
- La base de données est différente cette fois-ci (Gestion des mots de passe et des mails)
- La Section concernant les médecins n'est pas finie mais on peut créer un compte médecin et se connecter.
- La partie Patient est fonctionnelle, création de compte, connexion et gestion de ses rendez-vous (Annulation, modification et prise de rendez-vous)

CompteBancaire

- Application WPF simulant une gestion d'espace client pour gérer ses comptes bancaires (création, retrait, dépot, consultation des soldes etc..)
- J'utilise un transfert d'objets de form en form pour simuler une authentification pour l'espace client.
- Non finalisée pour le moment car il fallait se lancer sur les projets MVVM et ASP.NEt de mon faux Doctolib.



