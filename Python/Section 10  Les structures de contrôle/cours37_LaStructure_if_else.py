# This Python file uses the following encoding: utf-8
import os, sys

#37. La structure if, else

""" 
Tests à plusieurs cas

Parfois, il est pratique de tester si la condition est vraie ou si elle est fausse dans une même instruction if. Plutôt que d'utiliser deux instructions if, on peut se servir des instructions if et else :

On peut utiliser une série de tests dans la même instruction if, notamment pour tester plusieurs valeurs d'une même variable.

else ne possede aucune condition, il s'executte si et seuelement si la 1er condition n'est pas respecté

"""
a = input('Premier Nombre :')
b = input('Deuxieme Nombre :')

if a == b: # Si cette condition n'est pas verifier alors j'executte la condition "else"
    print('A est egale a B')
else:
    print('A est different de B')
    print('Reessayez Svp')