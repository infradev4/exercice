# This Python file uses the following encoding: utf-8
import os, sys

#Mini projet
"""

"""
from random import randint

nombre_a_deviner = randint(1, 100)
print(nombre_a_deviner)

nombre_essais = range(1,6)# 5 essais
for i in nombre_essais:

    essai = input('Entrer un nombre ({0} essai): '.format(i))

    if nombre_a_deviner == essai:
        print('Bravo, vous avez gagner')
    elif essai < nombre_a_deviner:
        print('Le nombre a devine a deviner est plus grand que ' + str(essai))
    else:
        print('Le nombre a devine a deviner est plus petit que ' + str(essai))

print('fin du jeu')

