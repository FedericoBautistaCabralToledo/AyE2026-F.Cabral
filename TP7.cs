void ejercicio1()
{
    Console.WriteLine("Ingresa un numero entero.");
    int num = Convert.ToInt32(Console.ReadLine());

    bool primo = true;

    if (num < 2)
    {
        primo = false;
    }
    else
    {

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                primo = false;
                break;
            }
        }
    }

    if (primo)
    {
        Console.WriteLine(num + " es primo");
    }
    else
    {
        Console.WriteLine(num + " no es primo");
    }
}
ejercicio1();

void ejercicio2()
{
    Console.WriteLine("Ingresa un número entero no negativo:");
    int num = Convert.ToInt32(Console.ReadLine());

    int factorial = 1;

    if (num < 0)
    {
        Console.WriteLine("Error: El número es negativo.");
    }
    else
    {
        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("El factorial de " + num + " es " + factorial);
    }
}
ejercicio2();

void ejercicio3()
{
    Console.WriteLine("Ingrese cuantos numeros de Fibonacci quiere ver.");
    int n = Convert.ToInt32(Console.ReadLine());

    int a = 0;
    int b = 1;

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(a);

        int sig = a + b;
        a = b;
        b = sig;
    }
}
ejercicio3();

void ejercicio4()
{
    int opcion = 0;

    while (opcion != 3)
    {
        Console.WriteLine("1 para que la consola diga hola, 2 para que la consola diga chau y 3 para finalizar el programa.");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("hola");
                break;

            case 2:
                Console.WriteLine("chau");
                break;

            case 3:
                break;


        }
    }
}
ejercicio4();