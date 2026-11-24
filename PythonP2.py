import random


def Ejercicio1():
    numero = random.randint(1, 10)
    # Inicializamos la variable con un valor fuera del rango (ej. 0) para entrar al bucle
    numeroEleg = 0

    while numeroEleg != numero:
        numeroEleg = int(input("Adivina el numero aleatorio del 1 al 10: "))

        if numeroEleg > numero:
            print("El numero elegido es mayor que el numero a adivinar")
        elif numeroEleg < numero:
            print("El numero elegido es menor que el numero a adivinar")

    # Cuando el bucle termina, significa que numeroEleg == numero
    print("¡Felicitaciones! El numero fue adivinado.")

Ejercicio1()


def Ejercicio2():
    # Pedile al usuario un número y mostrá todos los divisores que tiene
    numeroEleg = int(input("Ingrese un numero para mostrar todos sus divisores: "))
    divisor = 1  # Empezamos probando desde el 1

    print(f"Los divisores de {numeroEleg} son:")

    while divisor <= numeroEleg:
        # Si el resto de dividir numeroEleg por divisor es 0, es un divisor
        if numeroEleg % divisor == 0:
            print(divisor)

        divisor += 1  # Sumamos 1 para probar el siguiente número


Ejercicio2()


def Ejercicio3():

    a = 0
    b = 1

    print("Los primeros 20 números de la serie de Fibonacci son:")

    for i in range(20):
        print(a)

        siguiente = a + b

        a = b
        b = siguiente


Ejercicio3()


def suma(a, b):
    return a + b


def resta(a, b):
    return a - b


def multiplicacion(a, b):
    return a * b


def division(a, b):
    if b != 0:
        return a / b
    else:
        return "Error: División por cero"


def Ejercicio4():

    NumDec = int(input("Elija qué tipo de operación quiere realizar:"
                       "1- Suma "
                       "2- Resta "
                       "3- Multiplicación "
                       "4- División "
                       "Opción: "))

    a = int(input("Ingrese el primer número para su cuenta: "))
    b = int(input("Ingrese el segundo número para su cuenta: "))

    if NumDec == 1:
        print("Resultado:", suma(a, b))
    elif NumDec == 2:
        print("Resultado:", resta(a, b))
    elif NumDec == 3:
        print("Resultado:", multiplicacion(a, b))
    elif NumDec == 4:
        print("Resultado:", division(a, b))
    else:
        print("Opción inválida")


Ejercicio4()

def Ejercicio5():
    