using System.Reflection.Metadata;

void Balatro()
{
    string[] manoDelJugador = new string[8];
    bool jugadorTieneCartas = false;
    int opcionSeleccionada = 0;

    while (opcionSeleccionada != 3)
    {
        Console.WriteLine("1. Pedir cartas (Recibir 8 cartas)");
        Console.WriteLine("2. Descartar y reponer cartas");
        Console.WriteLine("3. Salir del juego");
        Console.Write("Seleccione una opción: ");


        if (int.TryParse(Console.ReadLine(), out opcionSeleccionada))
        {
            if (opcionSeleccionada == 1)
            {
                DarCartas(manoDelJugador);
                jugadorTieneCartas = true;
                MostrarManoActual(manoDelJugador);
            }
            else if (opcionSeleccionada == 2)
            {
                if (jugadorTieneCartas == false)
                {
                    Console.WriteLine("Primero tenes que pedir las cartas.");
                }
                else
                {
                    DescartarCartas(manoDelJugador);
                    MostrarManoActual(manoDelJugador);
                }
            }
            else if (opcionSeleccionada == 3)
            {
                Console.WriteLine("Saliendo.");
            }
            else
            {
                Console.WriteLine("Opción no válida. Elija solamente 1, 2 o 3.");
            }
        }
        else
        {
            Console.WriteLine("Debe ingresar un numero.");
            opcionSeleccionada = 0;
        }
    }
}

void DarCartas(string[] mano)
{
    string[] palosDisponibles = { "Corazones", "Diamantes", "Tréboles", "Picas" };
    string[] valoresDisponibles = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    Random generadorAleatorio = new Random();

    int posicion = 0;
    while (posicion < mano.Length)
    {
        string paloAlAzar = palosDisponibles[generadorAleatorio.Next(palosDisponibles.Length)];
        string valorAlAzar = valoresDisponibles[generadorAleatorio.Next(valoresDisponibles.Length)];

        mano[posicion] = valorAlAzar + " de " + paloAlAzar;
        posicion++;
    }
}

void DescartarCartas(string[] mano)
{
    Random generadorAleatorio = new Random();
    string[] palosDisponibles = { "Corazones", "Diamantes", "Tréboles", "Picas" };
    string[] valoresDisponibles = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    Console.Write("Elija el numero de cartas a descartar. (Mínimo 1, Máximo 8): ");
    if (int.TryParse(Console.ReadLine(), out int cantidadADescartar) && cantidadADescartar >= 1 && cantidadADescartar <= 8)
    {
        int cartasDescartadasSatisfechas = 0;

        while (cartasDescartadasSatisfechas < cantidadADescartar)
        {
            Console.Write($"Ingrese la posición de la carta {cartasDescartadasSatisfechas + 1} a eliminar (1 al 8): ");
            if (int.TryParse(Console.ReadLine(), out int posicionElegida) && posicionElegida >= 1 && posicionElegida <= 8)
            {
                int indiceDelVector = posicionElegida - 1;

                if (mano[indiceDelVector] != "Vacia")
                {
                    Console.WriteLine($"Eliminada: {mano[indiceDelVector]}");
                    mano[indiceDelVector] = "Vacia";
                    cartasDescartadasSatisfechas++;
                }
                else
                {
                    Console.WriteLine("Esa posición ya la descartaste. Elegi otra.");
                }
            }
            else
            {
                Console.WriteLine("Del 1 al 8.");
            }
        }
        int i = 0;
        while (i < mano.Length)
        {
            if (mano[i] == "Vacía")
            {
                string nuevoPalo = palosDisponibles[generadorAleatorio.Next(palosDisponibles.Length)];
                string nuevoValor = valoresDisponibles[generadorAleatorio.Next(valoresDisponibles.Length)];
                mano[i] = nuevoValor + " de " + nuevoPalo;
            }
            i++;
        }
    }
    else
    {
        Console.WriteLine("Cantidad no valida.");
    }
}

void MostrarManoActual(string[] mano)
{
    Console.WriteLine("\nTu mano actual es:");
    int i = 0;
    while (i < mano.Length)
    {
        Console.WriteLine($"{i + 1}. {mano[i]}");
        i++;
    }
}

Balatro();
