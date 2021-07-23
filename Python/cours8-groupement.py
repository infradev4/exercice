# This Python file uses the following encoding: utf-8
import os, sys

#Le groupement d'opérateurs logiques
# Ordre de priroté
#  1   2   3
# not and or

resultat = True and False or True
print(resultat)
#etape 1
# True and False | or True
#		=> False | or True
#		False or True
#		=> True

# afin de modifier la priorité il faut utiliser les paratheses
resultat = False and (False or True)
print(resultat)

#=> False

resultat = True or (False and False) and (True or False)
#		   True	or		False		 and	True
#Il n'y a pas assé de parathese, ici and est prioritaire à or donc:
#		True	or	|	False		 and	True
#		True	or		False	
#Puis 	True	or		False
# =>	True
print(resultat)

resultat = (True or (False and False)) and (True or False)
#		   True	or		False		 and	True
#La parathese, ici and est prioritaire à and dans la seconde partie, donc:
#		True	or		False		| and	True
#		True	and							True			
#Puis 	True	and		True
# =>	True
print(resultat)
