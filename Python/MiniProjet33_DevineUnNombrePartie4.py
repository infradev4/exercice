# This Python file uses the following encoding: utf-8
import os, sys

#Mini projet

#import random
"""
j'importe toutes les fonctions du modules random
"""
#import randon as rd 
#print(rd.randint(1, 10))
"""
J'utilise un alias "rd" afin d'appeler le module plus simplement et limiter la taille de mon script.
"""

from random import randint
"""
Si je sais que je ne vais utiliser que la fonction "randint" du module "random", je peux définit des l'import quelle fonction j'appel. de cette maniere il ne sera plus necessaire de deinir lors de l'écriture du script le "module.fonction"
"""
nombre_a_deviner = (randint(1, 100))
premier_essai = input('entrer un nombre (1er essai): ')

#Comparaison

resultat = premier_essai == nombre_a_deviner
print(resultat)


"""
La fonction input - Différence Python 2 / Python 3

Petit mot concernant une différence entre les versions 2 et 3 de Python.

Avec la version 2 de Python, la fonction input interprète ce que vous lui donnez.
Si vous entrez un nombre, la fonction input vous retournera donc un objet de type 'integer' (nombre).

Avec Python 3, la version input vous retourne en toute circonstance une chaîne de caractères.

Si vous voulez donc comparer un objet récupéré avec la fonction input dans Python 3 avec un nombre, il vous faudra le convertir au préalable en nombre grâce à la fonction int, comme ceci :

    mon_nombre = input("Entrez un nombre: ")
    mon_nombre = int(mon_nombre)
    resultat = mon_nombre < 10
    print(resultat)

Si vous obtenez une erreur du type  TypeError: '<' not supported between instances of 'str' and 'int' , cela signifie que vous essayez de comparer une chaîne de caractères avec un nombre, ce qui n'est pas possible. Il vous faut donc impérativement convertir toutes vos variables en nombres avec la fonction int pour pouvoir les comparer.

Si jamais vous avez des questions supplémentaires sur cette différence ou un problème dans votre script, n'hésitez pas à nous contacter sur Udemy ou sur le Discord pour que nous puissions vous venir en aide.

Bonne continuation !
"""





