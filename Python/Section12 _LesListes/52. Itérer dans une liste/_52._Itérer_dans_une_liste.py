#52. Itéreration dans une liste

#Faire une boucle à l'interieur d'une liste

#Pour un elements dans un autre element, on va itere avec 'for'
liste = ['Pierre','Paul','John']

#Je vais itere à traver cette liste
for tous_les_noms in liste:
    print(tous_les_noms)

#Resultat:
Pierre
Paul
John

#Je vais itere à traver cette liste et afficher 1 lignes pas clients 
for chaque_client in liste:
    print('Vous avez un client qui s appelle : {0} ' .format(chaque_client))

#ICi je passe à traver chaque element d'une liste
#Resultat:
Vous avez un client qui s appelle : Pierre 
Vous avez un client qui s appelle : Paul 
Vous avez un client qui s appelle : John 