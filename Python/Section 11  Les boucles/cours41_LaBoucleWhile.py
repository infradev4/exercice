# This Python file uses the following encoding: utf-8
import os, sys
import random

#41. La boucle While

""" 
While permet de répéter une série d'instructions tant qu'une condition est vraie

 
"""

"""
Temps que "i" est plus petit que 10 affiche "i"
Ic je cree une boucle, vu que "i" sera toujour inferieur à 10
"""
#i = 0
#while i < 10:
#    print(i)
"""
0
0
0
0
0
0
0
0
0
0
0
...
sauf si j'incremante "i"
"""
i = 0
while i < 10:
    print(i)
    i = 1 + i
print('i est plus grand que 10, Fin de la boucle')
"""
0
1
2
3
4
5
6
7
8
9
"""
continuer = 'o'
while continuer == 'o':
    print('La boucle continue.')
    continuer = raw_input('Voulez-vous continuer ? o/n ' )
print('Fin de la boucle')
"""
La boucle continue.
Voulez-vous continuer ? o/n o
La boucle continue.
Voulez-vous continuer ? o/n o
La boucle continue.
Voulez-vous continuer ? o/n n
Fin de la boucle
"""