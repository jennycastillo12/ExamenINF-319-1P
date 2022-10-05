def suma(n1,n2):
    return(n1+n2)
def resta(n1,n2):
    return(n1-n2)
def multi(n1,n2):
    return(n1*n2)
def divide(n1,n2):
    if n2==0:
        return 0
    else:
        return(n1/n2)


n1=int(input("Ingrese el primer número: "))
n2=int(input("Ingrese el primer número: "))
s=suma(n1,n2)
r=resta(n1,n2)
m=multi(n1,n2)
d=divide(n1,n2)
print("La suma es:", s)
print("La resta es:", r)
print("La multiplicación es:", m)
if d==0:
    print("No se puede dividir entre 0")
else:
    print("La división es:", d)