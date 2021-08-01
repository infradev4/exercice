#. Demander à l'utilisateur de rentrer des noms de films
# Ajouter ces films dans une liste
# Gérer les doublons
# Classer les films par ordre alphabétique
# Afficher la liste

#1) Creer une boucle afin d'inviter continuellement l'uitlisateur à entrer des noms de film
    #Une boucle While que l'on va changer pour oui ou non

#Presentation du projet:
print('Projet de création d\'une liste de films')

#PAr defaut continuer = o ouverture de la boucle
continuer = 'o'

#Creation d'une liste vide:
liste_de_films = []

#Je continue tant que la variable 'continuer'est == 'o'
while continuer == 'o':
    film_a_ajouter = input('Entrez un titre de film a ajouter: ')

    #Je convertie en minuscule toutes les entrées 
    film_a_ajouter_minuscule = [film.lower() for film in liste_de_films]
    
    #Avant d'ajouter un film je verifie si il y a u doublon
    #Si le film à ajouter est deja present dans la liste de film
    if film_a_ajouter in film_a_ajouter_minuscule:
        
        #J'affiche le doublon
        print('{0} est deja present dans la liste' .format(film_a_ajouter))

        #Si non, j'ajoute le film 
    else:
        liste_de_films.append(film_a_ajouter)

    continuer = input('Voulez-vous ajouter un autre film? o/n ')

    #Pour avoir un saut de ligne, entre les requettes:
    print('')

liste_de_films.sort()
print(liste_de_films)