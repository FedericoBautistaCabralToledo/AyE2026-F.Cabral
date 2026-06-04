void ejercicio1()
{

    int[,] Matriz1 =
    {
                 {14 , 27 , 37, 91},
                 {47 , 51 , 60, 52},
                 {73 , 82 , 90, 100},
                 {110, 120, 130, 140}
    };

    int result = 0;

    for (int columnas = 0; columnas < Matriz1.GetLength(0); columnas++)
    {
        for (int filas = 0; filas < Matriz1.GetLength(1); filas++)
        {
            Console.Write(Matriz1[columnas, filas] + " ");
        }
        Console.WriteLine();
    }

    result = Matriz1[0, 3] + Matriz1[0, 0] + Matriz1[3, 0] + Matriz1[3, 3];

    Console.WriteLine("La suma de las esquinas equivale a: " + result);
}
ejercicio1();

Console.WriteLine("------------------------");
void ejercicio2()
{
    int[,] matriz2 = {
        
        {45, 14, 33 }, 
        { 41, 54, 43 }, 
        { 91, 13, 92 } 
   
    };
    int suma = 0;
    int diagPrin = 0;
    int diagSecu = 0;
    int n = 3;

    for (int x = 0; x < 3; x++)
    {
        for (int c = 0; c < 3; c++)
        {
            Console.Write(matriz2[x, c] + " ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < n; i++)
    {
        diagPrin += matriz2[i, i];
        diagSecu += matriz2[i, n - 1 - i];
    }
    Console.WriteLine("La suma de la diagonal principal es: " + diagPrin);
    Console.WriteLine("La suma de la diagonal secundaria es: " + diagSecu);

}
ejercicio2();

Console.WriteLine("------------------------");

void ejercicio3()
{
    Console.Write("Ingrese el tamaño de la matriz: ");
    int n = int.Parse(Console.ReadLine());

    int[,] matriz = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int x = 0; x < n; x++)
        {
            if (i == x)
            {
                matriz[i, x] = 1;
            }
            else
            {
                matriz[i, x] = 0;
            }
        }
    }
    Console.WriteLine("Resultado:");
    for (int i = 0; i < n; i++)
    {
        for (int x = 0; x < n; x++)
        {
            Console.Write(matriz[i, x] + " ");
        }
        Console.WriteLine();
    }
}
ejercicio3();
