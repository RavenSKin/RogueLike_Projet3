## RogueLike_Projet3 - BONEPIT

# 1/Descriptions  

Controller : Clavier / souris 

 PEGI : +7  

Genre : fantaisies - fantastique  

Type: Rogue Like 

 
# 2/ Introduction 
BonePit est un RogueLike dans un univers médival-fantastique, en vue top-down. C'est un jeu dynamique dans lequel vous combattrez pour progresser dans les niveaux.
 

# 3/Univers 

 Reprenant l'ambiance d'un donjon du moyen-âge en y ajoutant de la magie. Dans ce jeu, vous incarnez un petit squelette qui a été une cible de résurrection de masse.
Donc vous vous réveillez en tant qu’ancien combattant protecteur des catacombes.
En colère pour n'avoir pu connaitre le sommeil éternel, vous allez chercher à travers le donjon afin de retrouver celui qui a troublé votre mort. 


# 4/Gameplay 

Camera : Top Down Générations aléatoire du donjon. 

Déplacement : Haut, Bas, Gauche, Droite. 

Lorsque le joueur commence son aventure avec une arme aléatoire. 

Lorsque le joueur subit des dégâts, il devient invulnérable pendant une demi seconde. 

Des ennemis appaitrons dans les salles de la carte.


# 5/Références  

Pour le système d’objets, nous nous sommes inspirés de plusieurs rogue Like tel que “ Pixel Dungeon “ + “ Binding Of Isaac “. 

 Pour la Direction Artistique, nous nous sommes inspire de “ Gonnler “ pour la création des personnages. 

 Pour le Gameplay nous avons pris connaissance de “DEAD CELLS “ & “CRYPT OF THE NECRODANCER” 
 
# 6/Code  
 
 Pour la generation procedural de salles , j'utilise principalement les raycast qui sont donc chargé de reperer si il y a un mur ou non et de construire en consequence 
 un cul de sac ou une nouvelle salle . Mon code se decompose donc en 2 parties : une chargé de tirer un rayon et une autre chargé de construire (la partie chargé de tirer un rayon etant en parent de celle chargé de construire )
 
 Les ennemies ont quant a eux une IA extremement simple chargée de se deplacer vers le joueur et d'attaquer quand elle est a portée , puis apres avoir attaquer , l'ennemi reste en cooldown pour se reposer 
 
 Pour le choix des salles speciales , je procede d'abord a une generation complete des salles vides , puis ensuite je choisi aleatoirement quelles salles seront speciales (en excluant la boss room et la start room )
# 7/Probleme 
Certains fichiers se sont perdu en faisant un commit sur la mauvaise branche , et en essayant de revenir a un commit anterieur certains sont revenu et d'autres ont été supprimés 
La video presente dans ce lien est la version la plus recente du projet : https://youtu.be/-3q144mEKPg

# 8/Ajouts utiles

Un Boss est prevu normalement , un script permettant de faire spawn la salle du boss pourrait etre interessant
Un Mouvement fluide de camera etait prevu(la camera etait supposé etre locké sur la salle

