#57. Définition et syntaxe
#Un tuple est une liste qui ne peut plus être modifiée.

#Créer un tuple
#Pour créer un tuple , vous pouvez utiliser la syntaxe suivante:
mon_tuple = ()

#Ajouter une valeur à un tuple
#Pour créer un tuple avec des valeurs, vous pouvez le faire de cette façon:
mon_tuple = (1, "ok", "olivier")

mon_tuple

#Resultat:
(1, "ok", "olivier")

type(ton_tuple)

#Resultat:
<class 'tuple'>

# Les parenthèses ne sont pas obligatoires mais facilite la lisibilité du code (rappelons que la force de python est sa simplicité de lecture):
mon_tuple = 1, 2, 3
type(mon_tuple)

#Resultat:
<type 'tuple'>


liste = [1,2,3]
type(liste)
<class 'list'>

ton_tuple = 1,2,3
type(ton_tuple)
<class 'tuple'>

# Afficher une valeur d'un tuple
#Le tuple est une sorte de liste, on peut donc utiliser la même syntaxe pour lire les données du tuple.

mon_tuple[0]

#Resultat:
1

#Et évidemment si on essaie de changer la valeur d'un index, l'interpreteur nous insulte copieusement:
mon_tuple[1] = "ok"

#Resultat:
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
TypeError: 'tuple' object does not support item assignment
