#Mini projet

from random import randint

nombre_a_deviner = randint(1, 10)

"""
nombre_essais = range(1,6)# 5 essais
Bravo, vous avez gagner en [1, 2, 3, 4, 5] essai(s)
"""
nombre_essais = range(1,6)# 5 essais

for i in nombre_essais:

    essai = input('Entrer un nombre ({0} essai): '.format(i))

    if essai < nombre_a_deviner:
        print('Le nombre a devine a deviner est plus grand que {0}'.format(essai))

    elif essai > nombre_a_deviner:
        print('Le nombre a devine a deviner est plus petit que {0}'.format(essai))

    else : # essai == nombre_a_deviner Ici il n'est pas nécesaire de definir la condition, puisque l'on est soit trot > sinon <, alors egal 
        print('Bravo, vous avez gagner en {0} essai(s), le nombre a deviner etait: {1}'.format(i, nombre_a_deviner))
        break
"""
# Si je ne mets pas de "break" meme apres avoir trouve le resultat, l'iteration va continue jusqu'a avoir fait 5 boucles
87
Entrer un nombre (1 essai): 87
Bravo, vous avez gagner en [1, 2, 3, 4, 5] essai(s)
Entrer un nombre (2 essai): 2
Le nombre a devine a deviner est plus grand que 2
Entrer un nombre (3 essai): 3
Le nombre a devine a deviner est plus grand que 3
Entrer un nombre (4 essai): 4
Le nombre a devine a deviner est plus grand que 4
Entrer un nombre (5 essai): 5
Le nombre a devine a deviner est plus grand que 5
fin du jeu
"""
if essai != nombre_a_deviner:
    print('Vous avez perdu')
    print('Le nombre a deviner etait: {0}'.format(nombre_a_deviner))

print('Fin du jeu')



