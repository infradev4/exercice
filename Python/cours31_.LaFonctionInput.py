# This Python file uses the following encoding: utf-8
import os, sys

#31. La fonction input()

""" 
Cette fonction permet de recuperer les données de l'utilisateur


"""
a = input('Entrer un premier nombre: ') # Ici je vais entrer un nombre "int"
print('Vous avez entre le nombre : ' + str(a)) # Dans cette ligne j'ai des chaine des caracteres, mais je fais appel a un numbre, ce qui pose probleme. Alors je le convertie en String avec la fonction "str()"
