#51. Trouver un élément

# in
# in est senseible à la casse
# Trouver un item dans une liste 
# Pour savoir si un élément est dans une liste, vous pouvez utiliser le mot clé in de cette manière: 

liste = ['Piere','Paul','John']
'John' in liste

#Resultat:
True

#Exemple d'uitlisation avec une strcuture conditionnelle

if 'John' in liste:
    print('John est un clien')
else:
    print('John n est pas un client')

#Resultat:
John est un clien