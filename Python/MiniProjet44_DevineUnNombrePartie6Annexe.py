²# This Python file uses the following encoding: utf-8
import os, sys

#Mini projet
"""

"""
from random import randint

nombre_a_deviner = randint(1, 10)

"""
nombre_essais = range(1,6)# 5 essais
Bravo, vous avez gagner en [1, 2, 3, 4, 5] essai(s)
"""
nombre_essais = range(1,6)# 5 essais

while i < nombre_essais:

    essai = input('Entrer un nombre ({0} essai): '.format(i))

    if essai < nombre_a_deviner:
        print('Le nombre a devine a deviner est plus grand que {0}'.format(essai))

    elif essai > nombre_a_deviner:
        print('Le nombre a devine a deviner est plus petit que {0}'.format(essai))

    else : # essai == nombre_a_deviner Ici il n'est pas nécesaire de definir la condition, puisque l'on est soit trot > sinon <, alors egal 
        print('Bravo, vous avez gagner en {0} essai(s), le nombre a deviner etait: {1}'.format(i, nombre_a_deviner))
        break
    i +=1


if essai != nombre_a_deviner:
    print('Vous avez perdu')
    print('Le nombre a deviner etait: {0}'.format(nombre_a_deviner))

print('Fin du jeu')



