# This Python file uses the following encoding: utf-8
import os, sys

#36. Vérifier une condition avec If

""" 
Les tests sont un élément essentiel à tout langage informatique si on veut lui donner un peu de complexité car ils permettent à l'ordinateur de prendre des décisions. Pour cela, Python utilise l'instruction if

if attend quelque chose de vrai ou faux, une condition.

La structure de controle ne fonctionne que si: 
nous avons un if
la condition "True ou false etc...."
les :
un retour a la ligne 
    une tabulation pour signifier l'action à réaliser
    Si il y a une autre tabulation une second action sera realiser

pour sortir de la boucle il revenir à la lagine
"""
if True:
    print('La condition est vrai')

if 5 > 10:
    print('la condition est fausse')

if 5 < 10:
    print('la condition est vrai')

a = input('Entrer un premier nombre: ')
b = input('Entrer un deuxieme nombre: ')

if a > b:
    print('Le premier nombre est plus grand que le deuxieme nombre')

if a < b:
    print('le deuxieme nombre est plus grand que le premier nombre')
