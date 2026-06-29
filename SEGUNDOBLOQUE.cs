using System.ComponentModel.Design;

void ejercicioA()
{
    Console.WriteLine("Adivine el número del 1 al 10.");
    Random random = new Random();
    int NumeroAdiv = random.Next(1, 11);
    int numeroIng = Convert.ToInt32(Console.ReadLine());

    while (NumeroAdiv != numeroIng)
    {
        if (NumeroAdiv < numeroIng)
        {
            Console.WriteLine("Menos.");
        }
        else if (NumeroAdiv > numeroIng)
        {
            Console.WriteLine("Mas");
        }
        else
        {
            Console.WriteLine("Usted ha ganado.");
            break;
        }
    }
}

void ejercicioB()
{
    Console.WriteLine("Ingrese un numero entero");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Ingrese numeros positivos");
    }
    for (int num = 1; num <= numero; num++)
    {
        if (numero % num == 0)
        {
            Console.WriteLine("Sus divisores son:" + num);
        }
    }
}
    void ejercicioC()
    {
        int n = 8;
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

    void ejercicioD()
    {
        int sumar()
        {
            Console.WriteLine("\nIngrese 2 números a sumar:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            return numero1 + numero2;
        }

        int restar()
        {
            Console.WriteLine("\nIngrese 2 números a restar:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            return numero1 - numero2;
        }

        int multiplicar()
        {
            Console.WriteLine("\nIngrese 2 números a multiplicar:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            return numero1 * numero2;
        }

        int dividir()
        {
            Console.WriteLine("\nIngrese 2 números a dividir:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return 0;
            }

            return numero1 / numero2;
        }

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            int resultado = 0;

            switch (opcion)
            {
                case "1":
                    resultado = sumar();
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case "2":
                    resultado = restar();
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case "3":
                    resultado = multiplicar();
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;
                case "4":
                    resultado = dividir();
                    Console.WriteLine($"El resultado de la división es: {resultado}");
                    break;
                case "5":
                    Console.WriteLine("CHAU");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }


    void ejercicioE()
    {
        Console.WriteLine("Ingresa un numero y te digo el factorial.");
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

void ejercicioF()
{
    Console.WriteLine("Cuantos turnos quiere generar");
    int turnos = int.Parse(Console.ReadLine());
    int numerodeturnos = 0;
    string[] nombres = new string[turnos];
    for (int i = 0; i <= turnos - 1; i++)
    {
        Console.WriteLine("Ingrese un nombre");
        nombres[i] = Console.ReadLine();
        Random aleatorio = new Random();
        numerodeturnos = aleatorio.Next(0, 100);
        Console.WriteLine("Paciente " + nombres[i] + " numero de orden: " + numerodeturnos);
    }
}

void ejercicioG()
    {
        int cont = 0;

        for (int test = 0; test < 100; test += 2)
        {
            cont++;
        }
        Console.WriteLine("Hay " + cont + " numeros pares de 1 a 100");
    }


    void ejercicioH()
    {
        bool pasaje = true;
        while (pasaje == true)
        {
            Console.WriteLine("1 para pasar de C° a F°, 2 para salir");
            int o = Convert.ToInt32(Console.ReadLine());

            switch (o)
            {
                case 1:
                    bool usuario = true;
                    while (usuario != false)
                    {
                        Console.WriteLine("Ingrese la temperatura(o 99999 para salir)");
                        int temperatura = Convert.ToInt32(Console.ReadLine());

                        if (temperatura == 99999)
                        {
                            usuario = false;
                        }
                        else
                        {
                            double fahrenheit = (temperatura * 1.8) + 32;
                            Console.WriteLine("Resultado: " + fahrenheit + "°F");
                        }
                    }
                    break;
                case 2:
                    pasaje = false;
                    Console.WriteLine("Saliendo");
                    break;

                default:
                    Console.WriteLine("Opcion no disponible");
                    break;
            }
        }
    }

    void ejercicioI()
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

void ejercicioJ()
{
    string[] nombres = new string[100];
    int cantidad = 0;

    while (true)
    {
        Console.WriteLine("Ingrese un nombre (fin para terminar):");
        string nombre = Console.ReadLine();

        if (nombre == "fin")
        {
            break;
        }

        nombres[cantidad] = nombre;
        cantidad++;
    }

    for (int i = 0; i < cantidad; i++)
    {
        Console.WriteLine("Hola " + nombres[i]);
    }
}

void ejercicioK()
{
    string nombre;
    string aux = "";
    bool sigue = true;
    int contador = 0;
    while (sigue)
    {
        Console.WriteLine("Ingrese un nombre");
        nombre = Console.ReadLine();
        if (aux == nombre)
        {
            Console.WriteLine("La cantidad de nombres ingresados antes del duplicado es de: " + (contador - 1));
            sigue = false;

        }
        aux = nombre;
        contador++;

    }
}

void ejercicioL()
{
    for (int y = 100; y <= 201; y++)
    {
        if (y % 7 == 0 && y % 10 == 3)
        {
            Console.WriteLine("los números entre 100 y 200 que sean múltiplos de 7 y terminan en 3 son:" + y);
        }
    }
}
void ejercicioN()
{
    bool asterisco = true;
    Console.WriteLine("Complete su formulario");

    Console.WriteLine("Ingrese su nombre");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese su gmail");
    string gmail = Console.ReadLine();

    foreach (char l in gmail)
    {
        if (l == '@')
        {
            asterisco = false;
            break;
        }
    }

    if (asterisco == true)
    {
        Console.WriteLine("Ingrese un gmail correcto");
    }
    else
    {
        Console.WriteLine("Perfecto  su formulario esta hecho" + "Nombre: " + nombre + " Edad: " + edad + " Gmail " + gmail);
    }
}

void ejercicioM()
{
    int total = 0;
    int contador = 0;
    int precio = 0;
    while (total < 1000)
    {
        Console.WriteLine("Ingrese el precio");
        precio = int.Parse(Console.ReadLine());
        total = total + precio;
        contador++;

    }
    Console.WriteLine("La cantidad de productos cargados es de: " + contador);
}
void ejercicioO()
{
    Console.WriteLine("Ingrese un numero de mas de 2 digitos");
    string num = Console.ReadLine();

    foreach (char digitos in num)
    {
        Console.WriteLine("Digitos por separado:" + digitos);
    }
}

void ejercicioP()
{
    Random manos = new Random();

    int contador = 0;

    int contmaquina = 0;

    bool manitas = true;

    while (manitas == true)
    {
        int numaleatorio = manos.Next(1, 4);

        Console.WriteLine("Elige 1 para piedra 2 para tijera 3 para papel");

        int juego = Convert.ToInt32(Console.ReadLine());

        if (numaleatorio == 1 && juego == 2)
        {
            contmaquina = contmaquina + 1;
        }
        else if (numaleatorio == 1 && juego == 3)
        {
            contador = contador + 1;
        }
        else if (numaleatorio == 2 && juego == 3)
        {
            contmaquina = contmaquina + 1;
        }
        else if (numaleatorio == 2 && juego == 1)
        {
            contador = contador + 1;
        }
        else if (numaleatorio == 3 && juego == 1)
        {
            contmaquina = contmaquina + 1;
        }
        else if (numaleatorio == 3 && juego == 2)
        {
            contador = contador + 1;
        }
        else if (numaleatorio == juego)
        {
            Console.WriteLine("empataron");
        }
        if (contador == 3)
        {
            Console.WriteLine("Ganaste mas veces tu" + contador + "-" + contmaquina);
            manitas = false;
        }
        else if (contmaquina == 3)
        {
            Console.WriteLine("Gano mas veces la maquina" + contmaquina + "-" + contador);
            manitas = false;
        }
    }
}

void ejercicioQ()
{
    Random yu = new Random();

    for (int q = 0; q < 10; q++)
    {
        int numerosaleatorios = yu.Next(1, 101);

        if (numerosaleatorios > 50)
        {
            Console.WriteLine("Los 10 numeros generados(1 al 100) mayores a 50 son:" + numerosaleatorios);
        }
    }
}

void ejercicioR()
{
    float promedio = 0;

    int notaalta = 0;

    int ingresos = 0;

    string nombrenotamasalta = "";

    while (ingresos < 5)
    {
        Console.WriteLine("Ingrese el nombre");

        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su nota");

        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota > 10 || nota < 1)
        {
            Console.WriteLine("Ingrese calificaciones validas");
        }
        else
        {
            promedio = promedio + nota;
            ingresos++;
        }
        if (nota > notaalta)
        {
            notaalta = nota;
            nombrenotamasalta = nombre;
        }
    }

    Console.WriteLine("El promedio es:" + promedio / 5);
    Console.WriteLine("La mejor nota la tiene:" + nombrenotamasalta + " con " + notaalta);
}

void ejercicioS()
{
    string abc = "abcdefghijklmnopqrstuvwxyz";
    string dadovuelta = "";

    for (int l = abc.Length - 1; l >= 0; l--)
    {
        dadovuelta = dadovuelta + abc[l];
    }
    Console.WriteLine("Abecedario invertido: " + dadovuelta);
}

bool ejecutando = true;

while (ejecutando == true)
{
    Console.WriteLine("Ingrese 1 para ejercicio a, 2 para ejercicio b, 3 para ejercicio c, 4 para ejercicio d, 5 para ejercicio e, 6 para ejercicio f, 7 para ejercicio g, 8 para ejercicio h, 9 para ejercicio i, 10 para ejercicio j, 11 para ejercicio k, 12 para ejercicio l, 13 para ejercicio m, 14 para ejercicio n, 15 para ejercicio o, 16 para ejercicio p, 17 para ejercicio q, 18 para ejercicio r , 19 para ejercicioa2 , 20 para ejercicio b2 , 21 para ejercicio c2, 22 para ejercicio d2, 23 para ejercicio e2 , 24 para ejercicio g2 , 25 para ejercicio h2 , 26 para ejercicio i2 , 27 para ejercicio l2 , 28 para ejercicio n2 , 29 para ejercicio o2 , 30 para ejercicio p2 , 31 para ejercicio q2 , 32 para ejercicio r2 , 33 para ejercicio s , 34 para ejercicio a3 ,35para salir");
    int numero = Convert.ToInt32(Console.ReadLine());

    switch (numero)
    {
        case 1:
            ejercicioA();
            break;

        case 2:
            ejercicioB();
            break;

        case 3:
            ejercicioC();
            break;

        case 4:
            ejercicioD();
            break;

        case 5:
            ejercicioE();
            break;

        case 6:
            ejercicioF();
            break;

        case 7:
            ejercicioG();
            break;

        case 8:
            ejercicioH();
            break;

        case 9:
            ejercicioI();
            break;

        case 10:
            ejercicioJ();
            break;

        case 11:
            ejercicioK();
            break;

        case 12:
            ejercicioL();
            break;

        case 13:
            ejercicioM();
            break;

        case 14:
            ejercicioN();
            break;

        case 15:
            ejercicioO();
            break;

        case 16:
            ejercicioP();
            break;

        case 17:
            ejercicioQ();
            break;

        case 18:
            ejercicioR();
            break;
        case 35:
            ejecutando = false;
            Console.WriteLine("Programa finalizado. ¡Hasta luego!");
            break;

        default:
            Console.WriteLine("Esa opción no existe, intenta con un número del 1 al 35.");
            break;
    }
}