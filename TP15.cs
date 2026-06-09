void ejercicio1()
{
    int[,] matriz = { 
        { 1, 2, 3 }, 
        { 4, 5, 6 }, 
        { 7, 8, 9 } 
    };

    for (int f = 0; f < 3; f++)
    {
        for (int c = 0; c < 3; c++)
        {
            Console.Write(matriz[f, c] + " ");
        }
        Console.WriteLine();
    }
}
ejercicio1();

Console.WriteLine("--------------------");

void ejercicio2()
{

    int[,] matriz = { 
        { 50, 25, 10 }, 
        { 65, 30, 5 }, 
        { 70, 45, 50 } 
    };
    int suma = 0;

    for (int x = 0; x < 3; x++)
    {
        for (int c = 0; c < 3; c++)
        {

            suma = suma + matriz[x, c];
            Console.Write(matriz[x, c] + " ");

        }
        Console.WriteLine();

    }
    Console.WriteLine("La suma de todos los numeros es: " + suma);
}
ejercicio2();

Console.WriteLine("--------------------");


void ejercicio3()
{
    try
    {
        int[,] matriz = {
        { 120, 140, 777 },
        { 25, 306, 444 },
        { 666, 42, 512 }
    };

        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(matriz[f, c] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Ingrese el numero de la fila.");
        int fila = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el numero de la columna.");
        int columna = int.Parse(Console.ReadLine());


        if (fila >= 0 && fila < 4 && columna >= 0 && columna < 4)
        {
            Console.WriteLine($"El elemento en la cordenada {fila},{columna} es : {matriz[fila, columna]}");
        }
        else
        {
            Console.WriteLine("Cordenadas no validas.");
        }
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Solo numeros permitidos.");
    }
}
ejercicio3();

Console.WriteLine("--------------------");

void ejercicio4()
{

    int[,] matriz = { 
        { 1, 2, 3, 4 }, 
        { 5, 6, 7, 8 }, 
        { 9, 10, 11, 12 }, 
        { 13, 14, 15, 16 }
    };
    int test = 2;

    for (int i = 0; i < 4; i++)
    {
        for (int x = 0; x < 4; x++)
        {

            if (matriz[x, i] > test)
            {
                test = matriz[x, i];
            }
        }

    }
    Console.WriteLine("El numero mas grande es: " + test);
}
ejercicio4();

Console.WriteLine("--------------------");
void ejercicio5()
{
    int[,] matriz = {
        { 1, 2, 3, 4 },
        { 5, 6, 7, 8 },
        { 9, 10, 11, 12 },
        { 13, 14, 15, 16 } };

    int sumafila = 0;
    int sumafila2 = 0;
    int sumafila3 = 0;
    int sumafila4 = 0;
    int sumacolumna = 0;
    int sumacolumna2 = 0;
    int sumacolumna3 = 0;
    int sumacolumna4 = 0;

    for (int x = 0; x < 4; x++)
    {
        sumacolumna += matriz[x, 0];
        sumacolumna2 += matriz[x, 1];
        sumacolumna3 += matriz[x, 2];
        sumacolumna4 += matriz[x, 3];

        sumafila += matriz[0, x];
        sumafila2 += matriz[1, x];
        sumafila3 += matriz[2, x];
        sumafila4 += matriz[3, x];

        for (int c = 0; c < 3; c++)
        {

            Console.Write(matriz[x, c] + " ");

        }
        Console.WriteLine();

    }
    Console.WriteLine("La suma de la primera columna es : " + sumacolumna);
    Console.WriteLine("La suma de la segunda columna es : " + sumacolumna2);
    Console.WriteLine("La suma de la tercer columna es : " + sumacolumna3);
    Console.WriteLine("La suma de la cuarta columna es :  " + sumacolumna4);
    Console.WriteLine("La suma de la primer fila es : " + sumafila);
    Console.WriteLine("La suma de la segunda fila es : " + sumafila2);
    Console.WriteLine("La suma de la tercer fila es: " + sumafila3);
    Console.WriteLine("La suma de la cuarta fila es : " + sumafila4);
}
ejercicio5();

Console.WriteLine("--------------------");

void ejercicio6()
{
    int[,] matriz = {
        { 1, 2, 3, 4 },
        { 5, 6, 7, 8 },
        { 9, 10, 11, 12 },
        { 13, 14, 15, 16 } 
    };
    int[,] matrizaux = new int[4, 4];
    for (int i = 0; i < 4; i++)
    {
        for (int x = 0; x < 4; x++)
        {
            matrizaux[i, x] = matriz[x, i];

        }
    }
    for (int i = 0; i < 4; i++)
    {
        for (int x = 0; x < 4; x++)
        {

            Console.Write(matrizaux[i, x] + " ");

        }
        Console.WriteLine();

    }
}
ejercicio6();

Console.WriteLine("--------------------");

void ejercicio7()
{
    try
    {
        int[,] matriz = {
    {1, 5, 3, 5 },
    { 8, 5, 9, 2},
    { 4, 5, 6, 7}
    };
        Console.WriteLine("Ingrese un numero y muestro cuantas veces aparece en la matriz.");
        int eleccion = int.Parse(Console.ReadLine());
        int acum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int x = 0; x < 4; x++)
            {
                if (eleccion == matriz[i, x])
                {
                    acum++;
                }
            }
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("La cantidad de veces que aparece ese numero es: " + acum);
        }
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Solo numeros permitidos.");
    }
}
ejercicio7();