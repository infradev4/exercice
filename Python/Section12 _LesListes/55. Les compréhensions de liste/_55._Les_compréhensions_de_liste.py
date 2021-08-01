#55. Les compréhensions de liste

#Multipliee les elements d'une liste par 2 et ajouter le resultat dans une autre liste
liste = [1,2,3,4,5]

liste_multipliee_par_deux = []

for i in liste:
    liste_multipliee_par_deux.append(i * 2)

print(liste)
print(liste_multipliee_par_deux)

# Ou bien il est possible de faire la meme chose beaucoup plus rapidement

liste_methode_2 = [1,2,3,4,5]
liste_3 = [i*2 for i in liste_methode_2]
print(liste_methode_2)
print(liste_3)