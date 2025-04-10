# Input Action
- Un input pour changer la lumières autour du personnage 
-> Script (LightToggle)
* Touche L (clavier)
* Touche A (manette, Button South Gamepad)

# Collisions And triggers 
- Une porte qui s'abaisse quand le joueur est à côté (Door.cs)
- Collision avec les ennemis
- Trigger avec piège et bonus
- Activation / Désactivation triggers murs en fonction du input (color) que l'utilisateur utilise

# Animation
- Une animation de porte (Animator) qui s'abaisse dès que le joueur est proche de la porte
Dès qu'il sort du trigger, une animation de fermeture de porte s'active ensuite 
- Animation des pièces
  
# Camera 
- Il y a 2 caméras, 
La thirdPersonCamera est uitilisé pour avoir une grande vu sur tout ce qui se passe (ennemis / pièces ...)
Toutefois, je remarque souvent que la caméra se prend dans les murs, ce qui cause un problème de vision, d'où l'utilisation d'un changement de point de vue de caméra.

# User Interface 

- Menu du jeu :
  - Press enter pour commencer à jouer (problème avec l'appui du bouton START GAME)

- Dans le jeu visible : 
  - Un score
  - Une map
  - Un timer
  - Une trap visuel (lancement de vidéo)

- Ecran victoire / defaite

# Prefabs 
- Création d'un dossier (environement du labyrinthe / Elements de la scène / Characters) + Séparation des matériaux
- Réutilisations des éléments de jeux comme (pièces, pièges, murs)

# Build
- J'ai ajouté à mes interactions (input Action) une façon d'interagir sur clavier et manette (Stick avec gamepad)

# Meaningfull names 
- nomenclature :
  - camelCase : pour les variables
  - PascalCase : pour les méthodes