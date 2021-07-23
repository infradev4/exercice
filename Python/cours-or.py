# This Python file uses the following encoding: utf-8
import os, sys

#or, compare 2 proposiotn entre elle et dertermine la valeur de verite
#Si une seule des deux valerus est vrai alors le resultat sera vrai
# Vrai ou vrai = vrai, si vrai ou faux, 1 des resultats est vrai alors vrai
print(True or False)	#True
print(False or False)	#False

print(10+5==15 or 10+2==10) #True
#une des deux valeurs doivent etre uste pour avoir un true

print(10+5==15 and 10+2==10) #False
#les deux valerus doivent etre juste pour avoir un true

#Avec l'opérateur 'or', il suffit qu'un seul des deux membres de l'opération soit 'True' pour que le résultat soit 'True'.