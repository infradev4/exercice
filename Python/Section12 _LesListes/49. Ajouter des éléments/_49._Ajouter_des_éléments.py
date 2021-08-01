#Ajouter 1 element dans une liste:
liste = ['Pierre','Paul']

#ajouter 1 élément avec .append()  (qui signifie "ajouter" en anglais)
#Par defaut il sera ajouter à la fin
liste.append('Jacques')

#Resultat
print(liste)
['Pierre', 'Paul', 'Jacques']

#Pour ajouter une entre dans la liste a une position precise utiliser .insert()
#.insert() utilise deux parametres un indice et une entree .insert(1,'Kevin')
#indice = index
liste.insert(1,'Kevin')

#Resultat
['Pierre', 'Kevin', 'Paul', 'Jacques']
liste.insert(0,'Bob')

#Resultat
['Bob', 'Pierre', 'Kevin', 'Paul', 'Jacques']

#Ajouter PLUSIEURS elements dans une liste:

# Étend la liste en y ajoutant tous les éléments de l'itérable, ou ajouter une liste à une autre liste.
# list.extend(iterable)
liste.extend(['Galere','Eau'])
liste

#Resultat
['Bob', 'Pierre', 'Kevin', 'Paul', 'Jacques', 'Galere', 'Eau']

#Ajouter PLUSIEURS elements dans une liste avec la CONCATENATION:

liste += ['Tornade','Foudre','Tonnerre']

#Resultat
liste
['Bob', 'Pierre', 'Kevin', 'Paul', 'Jacques', 'Galere', 'Eau', 'Tornade', 'Foudre', 'Tonnerre']

liste += ['France','Espagne','Suisse']

#Resultat
liste
['Bob', 'Pierre', 'Kevin', 'Paul', 'Jacques', 'Galere', 'Eau', 'Tornade', 'Foudre', 'Tonnerre', 'France', 'Espagne', 'Suisse']
