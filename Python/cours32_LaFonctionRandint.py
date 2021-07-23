# This Python file uses the following encoding: utf-8
import os, sys

#32. La fonction randint()

""" 
randint(0, 10) du module random. 
Cette fonction renvoie un nombre entier tiré aléatoirement entre 0 inclus et 10 inclus.

randint est une fonction du module random.
Afin de pouvoir utiliser la fonction randint il est necessaire d'y faire appel avec le module random.
Pour cela il faut faire appel à un import "import random" de cette facon l'utilisation de la fonction est possible.

L'utilisation de la syntaxe import module permet d'importer tout une série de fonctions organisées par « thèmes ». Par exemple, les fonctions gérant les nombres aléatoires avec random .

La syntaxe module.fonction() est là pour rappeler de quel module provient la fonction en un coup d’œil !

random.randint(1, 10)

Exemple:
La syntaxe suivante est-elle valide ?

    import random
    nombre_aleatoire = randint(1, 10)

Non, le script va retourner une erreur.
 La fonction randint n'est pas préfixé du nom du module, Python ne saura donc pas où aller la chercher et retournera une erreur de type NameError.

"""
import random

nombre_aleatoire = random.randint(1, 10)
print(nombre_aleatoire)
