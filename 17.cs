void ejercicioA()
{

    int[][] matrizIrregular =
    {
         new int[] { 1, },
        new int[] { 2, 3,},
       new int[] { 4, 5, 6},
     new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            Console.Write(matrizIrregular[i][x] + " ");
        }
        Console.WriteLine(" ");
    }
}
ejercicioA();

Console.WriteLine("-------------------");
void ejercicioB()
{
    int test = 0;

    int[][] matrizIrregular =
        {
         new int[] { 1, },
        new int[] { 2, 3,},
       new int[] { 4, 5, 6},
     new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            test++;

        }

    }
    Console.WriteLine("Hay " + test + " elementos");
}
ejercicioB();

Console.WriteLine("--------------------");

void ejercicioC()
{
    int testELEMENTOS = 0;
    int indice = 0;

    int[][] matrizIrregular =
        {
         new int[] { 1, },
        new int[] { 2, 3,},
       new int[] { 4, 5, 6},
     new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            if (matrizIrregular[i].Length > testELEMENTOS)

                testELEMENTOS = matrizIrregular[i].Length;
            indice = i;
        }
    }
    Console.WriteLine("La fila que tiene mas elementos es " + indice + " y tiene: " + testELEMENTOS);
}
ejercicioC();

Console.WriteLine("------------------");
void ejercicioD()
{
    int[][] matrizIrregular =
       {
         new int[] { 1, },
        new int[] { 2, 3,},
       new int[] { 4, 5, 6},
     new int[] { 7, 8, 9, 10 }
    };

    int[] sumasPorFila = new int[matrizIrregular.Length];

    for (int x = 0; x < matrizIrregular.Length; x++)
    {
        int sumaFila = 0;

        for (int y = 0; y < matrizIrregular[x].Length; y++)
        {
            sumaFila += matrizIrregular[x][y];
        }
        sumasPorFila[x] = sumaFila;
    }
    for (int i = 0; i < sumasPorFila.Length; i++)
    {
        Console.WriteLine($"La fila {i} da {sumasPorFila[i]}");
    }

}
ejercicioD();

Console.WriteLine("------------------");


void ejercicioE()
{
    int numeromayor = 0;

    int posx = 0;
    int posy = 0;

    int[][] matrizIrregular =
    {
        new int[] { 1, },
        new int[] { 2, 3, },
        new int[] { 4, 5, 6 },
        new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            if (matrizIrregular[i][x] > numeromayor)
            {
                numeromayor = matrizIrregular[i][x];
                posx = i;
                posy = x;
            }
        }
    }
    Console.WriteLine($"Numero mas grande: {numeromayor} , posicion {posx};{posy}");
}
ejercicioE();

void ejercicioF()
{
    int[][] matrizIrregular =
    {
        new int[] { 1, },
        new int[] { 2, 3, },
        new int[] { 4, 5, 6 },
        new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        int suma = 0;

        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            suma += matrizIrregular[i][x];
        }
        double promedio = (double)suma / matrizIrregular[i].Length;

        Console.WriteLine($"El promedio de los alumnos: {promedio}");
    }
}
ejercicioF();

bool ejercicioG(int[][] matriz, int x)
{
    for (int i = 0; i < matriz.Length; i++)
    {
        for (int j = 0; j < matriz[i].Length; j++)
        {
            if (matriz[i][j] == x)
            {
                return true;
            }
        }
    }

    return false;
}

int[][] matrizIrregular =
{
    new int[] { 1 },
    new int[] { 2, 3 },
    new int[] { 4, 5, 6 },
    new int[] { 7, 8, 9, 10 }
};

Console.WriteLine("Ingrese un numero para ver si existe en la matriz irregular:");
int numeroABuscar = Convert.ToInt32(Console.ReadLine());

bool resultado = ejercicioG(matrizIrregular, numeroABuscar);

Console.WriteLine($"El numero esta en la matriz?: {resultado}");