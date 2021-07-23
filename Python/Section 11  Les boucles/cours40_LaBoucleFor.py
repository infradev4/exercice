# This Python file uses the following encoding: utf-8
import os, sys

#40. La boucle For

""" 
for permet de répéter un nombre de fois defini une instruction ou boucle
pour quoi dans (a l'interieur de quoi il faut boucler) quoi
pour = for
quoi = variable ou i
dans = in
quoi = bonsoir

la varaible 'lettre' va boucler au temps de fois qu'il y a de caractere dans "bonjour".
La variable 'lettre' va etre assigné a au 1er caractere de "bonjour", comme cela,
lettre = b (passage 1)
lettre = o (passage 2)
....
lettre = r (passage 7) il y a 7 caracteres dans bonjour, donc 7 itération 
"""


# Pour le nombre de lettre dans 'bonjour' afficher lettre
b = 'bonjour'
for lettre in b:
    print(lettre)
"""
b
o
n
j
o
u
r
"""
for lettre in 'Bonsoir':
    print(lettre)
"""
B
o
n
s
o
i
r
"""

#boucle avec un list [], 4 itération
for chiffre in [1,2,3,4]:
    print(chiffre)
"""
1
2
3
4
"""

liste_de_valeurs = range(10) 
print(liste_de_valeurs)
"""
[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
"""

for chiffre in range(5):
    print(chiffre)
"""
0
1
2
3
4
"""

