#50. Retirer des éléments
# list.remove(x)
#Supprime de la liste le premier élément dont la valeur est égale à x. 
#Une exception ValueError est levée s'il n'existe aucun élément avec cette valeur.

liste = ['Pierre','Paul']
liste.remove('Pierre')

#Resultat:
liste
['Paul']

#list.pop([i])
#Cette methode permet de recuperer l'entree supprimer dans une variable

#Enlève de la liste l'élément situé à la position indiquée et le renvoie en valeur de retour. 
#Si aucune position n'est spécifiée, a.pop() enlève et renvoie le dernier élément de la liste 
#(les crochets autour du i dans la signature de la méthode indiquent que ce paramètre est facultatif et 
#non que vous devez placer des crochets dans votre code ! 
liste = ['Bob', 'Pierre', 'Kevin', 'Paul', 'Jacques', 'Galere', 'Eau', 'Tornade', 'Foudre', 'Tonnerre']

#Resultat:
liste
['Bob', 'Pierre', 'Kevin', 'Paul', 'Jacques', 'Galere', 'Eau', 'Tornade', 'Foudre', 'Tonnerre']

ma_valeurs_supprime = liste.pop(0)
#Resultat:
Bob
#Resultat:
liste
['Pierre', 'Kevin', 'Paul', 'Jacques', 'Galere', 'Eau', 'Tornade', 'Foudre', 'Tonnerre']

#Supprimer une entrée avec un index
#Il existe un moyen de retirer un élément d'une liste à partir de sa position au lieu de sa valeur : 
#l'instruction del. Elle diffère de la méthode pop() qui, elle, renvoie une valeur.

del liste[0]

#Resultat:
liste
['Kevin', 'Paul', 'Jacques', 'Galere', 'Eau', 'Tornade', 'Foudre', 'Tonnerre']

#L'instruction del peut également être utilisée pour supprimer des tranches d'une liste ou la vider complètement
   -7  -6  -5  -4  -3  -2  -1
  0   1   2   3   4   5   6
+---+---+---+---+---+---+---+
| B | o | n | j | o | u | r |
+---+---+---+---+---+---+---+
0   1   2   3   4   5   6   7

a = [1, 66.25, 333, 333, 1234.5]
#Resultat:
a
[1, 66.25, 333, 333, 1234.5]

#Pour n'avoir que les entrees suivantes dans la liste et suppriemr le reste ([1, 66.25, 1234.5])
del a[2:4]

#Resultat:
a
[1, 66.25, 1234.5]