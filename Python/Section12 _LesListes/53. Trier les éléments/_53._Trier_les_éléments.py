# 53. Trier les éléments


#list.sort(*, key=None, reverse=False)
#Ordonne les éléments dans la liste 
#(les arguments peuvent personnaliser l'ordonnancement, voir sorted() pour leur explication).

#Creation de la liste
liste = [5,7,3,1,9,8,2,4,6]

#FOnction de trie sans parametre
liste.sort()

#Resultat:
liste
[1, 2, 3, 4, 5, 6, 7, 8, 9]

#Pour trier sans modifier la liste de maniere temporaire et visuel, utiliser "sorted":

#Creation de la liste
liste = [5,7,3,1,9,8,2,4,6]

#FOnction de trie temporaire
sorted(liste)
[1, 2, 3, 4, 5, 6, 7, 8, 9]

#Si je verifie l'etat de la liste; je  vois qu'il n y a pas de modification de l'ordre

#Resultat:
liste
[5, 7, 3, 1, 9, 8, 2, 4, 6]

#Pour suavgarder les modification du trillage je dois reafeccter la modification à ma liste
liste = sorted(liste)

#Resultat:
liste
[1, 2, 3, 4, 5, 6, 7, 8, 9]


#list.reverse()
#Inverse l'ordre des éléments dans la liste.

#Creation de la liste
liste = [5,7,3,1,9,8,2,4,6]

#Trie ordre decroissant
liste.reverse()

#Oubien utiliser la fonction 'sort' mais en modifiant le parametre par defaut en (reverse=True)
liste.sort(reverse=True)
liste
[9, 8, 7, 6, 5, 4, 3, 2, 1]