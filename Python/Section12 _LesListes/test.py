#. Demander à l'utilisateur de rentrer des noms de films
# Ajouter ces films dans une liste
# Gérer les doublons
# Classer les films par ordre alphabétique
# Afficher la liste

#1) Creer une boucle afin d'inviter continuellement l'uitlisateur à entrer des noms de film
    #Une boucle While que l'on va changer pour oui ou non

#Presentation du projet:
print('Projet de création d\'une liste de films')
continuer = 'o'

#Creation d'une liste vide:
liste_de_films = []

#Je continue tant que la variable 'continuer'est == 'o'
while continuer == 'o':
    film_a_ajouter = input('Entrez un titre de film a ajouter: ')
    liste_de_films.append(film_a_ajouter)

    continuer = input('Voulez-vous ajouter un autre film? o/n ')

liste_de_films.sort()
print(liste_de_films)