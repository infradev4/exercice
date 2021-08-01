# This Python file uses the following encoding: utf-8
import os, sys

#Mini projet
"""

"""
from random import randint

nombre_a_deviner = randint(1, 100)
print(nombre_a_deviner)


premier_essai = input('Entrer un nombre: ')

if nombre_a_deviner == premier_essai:
    print('Bravo, vous avez gagner')
elif premier_essai < nombre_a_deviner:
    print('Le nombre a devine a deviner est plus grand que ' + str(premier_essai))
#elif premier_essai > nombre_a_deviner:
# Ici "elif" est inutile, soit on est egale ou inferieur ou superieur, il n'y aura pas d'autre possibilite pour avoir une 4eme condition avec "else" 
else:
    print('Le nombre a devine a deviner est plus petit que ', str(premier_essai))
    print('fin du jeu')

