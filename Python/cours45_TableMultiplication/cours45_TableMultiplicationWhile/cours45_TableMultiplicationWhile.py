continuer = 'o'
multiplicateur = range(1,11)

while continuer == 'o':
    table_Multiplication = input(' Entrez un Nombre: ')
    
    for i in multiplicateur:
        print('{0} X {1} = {2}' .format(i,table_Multiplication,int(table_Multiplication) * i))

    continuer = input('Voulez-vous continuer? o/n ')
print('Fin du script')