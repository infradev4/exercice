#58. Récupérer le minimum et le maximum
#La fonction Python min () renvoie la valeur la plus basse d'une liste d'éléments. 
#La fonction min () peut être utilisée pour trouver le plus petit nombre dans une liste 
#ou la première chaîne qui apparaîtrait dans la liste si la liste était classée par ordre alphabétique.


#Trouver les valeurs max et min d'une liste
mon_tuple = (5,10,15)

#Resultat:
mon_tuple
(5, 10, 15)

max(mon_tuple)

#Resultat:
15

min(mon_tuple)
#Resultat:
5

#Python Min et Max avec une liste de chaînes des caractères
#Dans les exemples ci-dessus, nous avons utilisé les méthodes min () et max () pour trouver les valeurs les plus petites et les plus grandes dans une liste de nombres.
#Les méthodes min () et max () peuvent également être utilisées pour rechercher les caractères les plus petits et les plus grands des chaînes dans une liste. 
#Dans ce cas, le plus petit et le plus grand font référence à la valeur du mot dans la table ascii.

liste = ["rouge", "jaune", "vert", "orange" ]

print (max (liste))
#Resultat:
vert

print (min (liste))
#Resultat:
jaune
