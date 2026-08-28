# Pluie-de-poules
Un mystérieux phénomène météorologique frappe la région : il pleut des poules ! Votre mission est de créer un simulateur pour étudier ce phénomène étrange.

Objectif : Programmer la chute de plusieurs poules du haut de l'écran jusqu'au sol.

## Spécifications fonctionnelles
- Chaque poule doit tomber en ligne droite (une à la fois).
- Les poules apparaissent à des positions horizontales aléatoires (ex. entre les colonnes 10 et 60).
- Les poules partent toutes du même point de départ et arrivent toutes à 2 lignes du bas de l'écran.

## Spécifications techniques
- Cliquer sur Use this template pour faire une copie indépendante de ce dépôt, puis clonez le pour l'avoir en local.
- Vous devez utiliser des fonctions dans votre programme. Celles-ci doivent être documentées.
- Vous devez utiliser au moins un tableau et/ou une liste (faites le bon choix!).

## Indications
- Ajouter la ligne suivante pour que la console soit capable d'afficher des emojis 🐔 : ```Console.OutputEncoding = System.Text.Encoding.UTF8;```
- Positionner le curseur sur une position spécifique dans la console:
  ```
  Console.SetCursorPosition(x, y);
  x = la colonne (de gauche à droite, commence à 0).
  y = la ligne (de haut en bas, commence à 0).
  ```
- Effacer la console : ```Console.Clear();```
- Hauteur de la fenêtre console en nombre de lignes : ```Console.WindowHeight```
- Générer un nombre aléatoire :
  ```C# 
	Random random = new Random(); // Une seule instance de Random pour éviter les répétitions
	random.Next(posMin, posMax + 1);
  ```
- ```Thread.Sleep(50);```
