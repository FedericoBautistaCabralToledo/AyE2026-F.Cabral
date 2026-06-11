void ttt()
{
    bool juegan = true;
    int turnos = 0;
    char jugadorActual = 'X';

    char[,] matriz =
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    void DibujarTablero()
    {
        Console.Clear();
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(" " + matriz[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    bool EsJugadaValida(int fila, int columna)
    {
        if (fila < 0 || fila > 2 || columna < 0 || columna > 2) 
            return false;
        if (matriz[fila, columna] == 'X' || matriz[fila, columna] == 'O') 
            return false;
        return true;
    }

    bool LeerXGanar(char jugador)
    {
        for (int f = 0; f < 3; f++)
            if (matriz[f, 0] == jugador && matriz[f, 1] == jugador && matriz[f, 2] == jugador) return true;

        for (int c = 0; c < 3; c++)
            if (matriz[0, c] == jugador && matriz[1, c] == jugador && matriz[2, c] == jugador) return true;

        if (matriz[0, 0] == jugador && matriz[1, 1] == jugador && matriz[2, 2] == jugador) return true;
        if (matriz[0, 2] == jugador && matriz[1, 1] == jugador && matriz[2, 0] == jugador) return true;

        return false;
    }

    void RealizarTurno(char jugador)
    {
        int casilla = 0;
        int fila = 0;
        int columna = 0;
        bool movimientoValido = false;

        while (!movimientoValido)
        {
            DibujarTablero();
            Console.WriteLine($"Turno {jugador}: Elija una casilla (1-9):");

            try
            {
                casilla = int.Parse(Console.ReadLine());
                if (casilla >= 1 && casilla <= 9)
                {
                    fila = (casilla - 1) / 3;
                    columna = (casilla - 1) % 3;

                    if (matriz[fila, columna] != 'X' && matriz[fila, columna] != 'O')
                    {
                        matriz[fila, columna] = jugador;
                        movimientoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Esa casilla ya está ocupada.");
                    }
                }
                else
                {
                    Console.WriteLine("Numero debe ser del 1 al 9.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada invalida, ingrese un numero.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Numero ingresado muy grande.");
            }
        }

        DibujarTablero();
    }

    while (juegan)
    {
        RealizarTurno(jugadorActual);
        turnos++;

        if (LeerXGanar(jugadorActual))
        {
            Console.WriteLine($"El jugador {jugadorActual} ha ganado.");
            juegan = false;
        }
        else if (turnos == 9)
        {
            Console.WriteLine("Es un empate.");
            juegan = false;
        }
        else
        {
            if (jugadorActual == 'X')
            { 
                jugadorActual = 'O'; 
            }
            else 
            { 
                jugadorActual = 'X'; 
            }
        }
    }
}
ttt();