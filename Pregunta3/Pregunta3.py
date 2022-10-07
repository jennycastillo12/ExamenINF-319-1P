# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
from pyswip import Prolog

prolog = Prolog()

prolog.assertz("padre(damian,ruth)")
prolog.assertz("padre(damian,juan)")
prolog.assertz("padre(damian,miguel)")
prolog.assertz("padre(damian,lupe)")

prolog.assertz("madre(flora,ruth)")
prolog.assertz("madre(flora,juan)")
prolog.assertz("madre(flora,miguel)")
prolog.assertz("madre(flora,lupe)")

prolog.assertz("padre(jose,leticia)")
prolog.assertz("madre(ruth,leticia)")

prolog.assertz("padre(juan,paula)")
prolog.assertz("padre(juan,gabriel)")
prolog.assertz("madre(rosa,paula)")
prolog.assertz("madre(rosa,gabriel)")


prolog.assertz("abuelo(damian,leticia)")
prolog.assertz("abuelo(damian,paula)")
prolog.assertz("abuelo(damian,gabriel)")
prolog.assertz("abuela(flora,leticia)")
prolog.assertz("abuela(flora,paula)")
prolog.assertz("abuela(flora,gabriel)")

prolog.assertz("nieto(leticia,damian,flora)")
prolog.assertz("nieto(paula,damian,flora)")
prolog.assertz("nieto(gabriel,damian,flora)")

prolog.assertz("primo(leticia,paula)")
prolog.assertz("primo(leticia,gabriel)")
prolog.assertz("primo(paula,gabriel)")
#print("***********PADRE*********************")
#for elemento in prolog.query("padre(X,Y)"):
 #   print(elemento["X"], "es el padre ",elemento["Y"])
#print("***********MADRE*********************")
#for elemento in prolog.query("madre(X,Y)"):
 #   print(elemento["X"], "es la madre ",elemento["Y"])
print("********ABUELO*********")
for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], "es el abuelo ",elemento["Y"])
print("*****ABUELA*********")

for elemento in prolog.query("abuela(X,Y)"):
    print(elemento["X"], "es la abuela ",elemento["Y"])
print("********nietos*********")
for elemento in prolog.query("nieto(X,Y,Z)"):
    print(elemento["X"], "es nieta de ",elemento["Y"], "y ",elemento["Z"])
print("********PRIMOS************")
for elemento in prolog.query("primo(X,Y)"):
    print(elemento["X"], "Y ",elemento["Y"],"SON PRIMOS")




