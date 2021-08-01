#Methode pour afficher un element positionner à un endroit precis avec un indice
ma_liste = ['B','o','n','j','o','u','r']
ma_liste[3]
'j'

#Methode pour afficher un element en partant de la fin avec un indice
ma_liste = ['B','o','n','j','o','u','r']
ma_liste[-4]
'j'

#Pour compter les elements contenues dans une liste, le nombre d'indice
len(ma_liste)
7

['B','o','n','j','o','u','r']

   -7  -6  -5  -4  -3  -2  -1
  0   1   2   3   4   5   6
+---+---+---+---+---+---+---+
| B | o | n | j | o | u | r |
+---+---+---+---+---+---+---+
0   1   2   3   4   5   6   7

Avec un indice je ne vais recuperer qu'une seule lettre ou chiffre

Pour recuperer plusieur element d'une liste je ne vais pas utiliser les indices mais les tranches.

Tranches
Un autre avantage des listes est la possibilité de sélectionner une partie d'une liste en utilisant un indiçage construit 
sur le modèle [m:n+1] pour récupérer tous les éléments, du émième au énième (de l'élément m inclus à l'élément n+1 exclu). 
On dit alors qu'on récupère une tranche de la liste, par exemple :

ma_liste[0:3]
['B', 'o', 'n']

Pour recuperer les 3 dernieres lettre de 'BOnjour'
   -7  -6  -5  -4  -3  -2  -1
  0   1   2   3   4   5   6
+---+---+---+---+---+---+---+
| B | o | n | j | o | u | r |
+---+---+---+---+---+---+---+
0   1   2   3   4   5   6   7

ma_liste[4:]
['o', 'u', 'r']

Il n'est pas nécéssaire de d'indiquer la postion de la derneire lettre. J'indique seulement le debut et je laisse vide pour la fin'

ma_liste[:4]
['B', 'o', 'n', 'j']

Si je ne specifie pas la postion du debut, il commencera automatiquement pas la position 0 jusq'a la valeur indiquer'

ma_liste[:]
['B', 'o', 'n', 'j', 'o', 'u', 'r']
Si je ne scpecifie aucun indice a gauche du : ou à droite, il affichera toutes les valeurs da la liste

ma_liste[:-4]
['B', 'o', 'n']

Question 1 :

Quel symbole utilise-t-on pour définir une liste ?
Les crochets []

Question 2 :

Quelle fonction utilise-t-on pour trouver la longueur d'une liste ?
len(ma_liste)

Question 3 :

Comment accède-t-on à un élément dans une liste ?
Avec les crochets : ma_liste[2]

Question 4 :

Quel élément nous retourne la syntaxe suivante :
ma_liste[-1] 
Le dernier élément d'une liste.