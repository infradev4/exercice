# This Python file uses the following encoding: utf-8
import os, sys

#38. La structure If, elif, else

""" 
Condition elif
Il est possible d'ajouter autant de conditions précises que l'on souhaite en ajoutant le mot clé elif , contraction de "else" et "if", qu'on pourrait traduire par "sinon".
# Si cette condition n'est pas verifier alors je teste d'autre condition avec "elif" (sinon)

Question 1 :

Est-on obligé de mettre la structure if, elif, else dans cet ordre respectivement ?
Oui, le if doit arriver en premier, suivit d'elif et de else pour finir.

Question 2 : 
Peut-on avoir plusieurs elif dans une structure conditionnelle ?
Oui, on peut avoir autant d'elif que l'on veut !
"""
a = input('Premier Nombre :')
b = input('Deuxieme Nombre :')

if a == b: 
    print('A est egale a B')
elif a < b:
    print('A est plus petit que B')
elif a > b:
    print('A est plus grand que B')
else:
    print('A est different de B')
    print('Reessayez Svp')