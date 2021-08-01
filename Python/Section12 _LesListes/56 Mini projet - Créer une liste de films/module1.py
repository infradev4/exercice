nom_Film = [] 
longueur_max_de_la_liste = 6
while len(nom_Film ) < longueur_max_de_la_liste:
    item = input("Enter your Item to the List: ")
    nom_Film .append(item)
    print(nom_Film) 
print('That\'s your Shopping List')
print(nom_Film)
