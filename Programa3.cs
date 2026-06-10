void ahorcado()
{
    string palabra = "ENCHUFE";
    int intentos = 7;
    string palabra2 = "_______";


    Console.WriteLine("Intente adivinar las letras, tiene 7 intentos.");
    Console.WriteLine(palabra2);

    while (intentos > 0 && palabra2.Contains('_'))
    {
        Console.WriteLine($"Palabra actual: {palabra2}");
        Console.Write("Ingrese una letra: ");
        string entrada = Console.ReadLine().ToUpper();

        if (entrada.Length == 0) continue;
        char letraUsuario = entrada[0];

        if (palabra.Contains(letraUsuario))
        {
            string nuevaPalabra2 = "";
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == letraUsuario || palabra2[i] != '_')
                {
                    nuevaPalabra2 += palabra[i];
                }
                else
                {
                    nuevaPalabra2 += "_";
                }
            }
            palabra2 = nuevaPalabra2;
            Console.WriteLine("Esa letra si esta.");
        }
        else
        {
            intentos--;
            Console.WriteLine($"La letra '{letraUsuario}' no esta. {intentos} intentos.");
        }
    }
    if (!palabra2.Contains('_'))
    {
        Console.WriteLine($"Ganaste. La palabra era: {palabra}");
    }
    else
    {
        Console.WriteLine($"Perdiste. La palabra era: {palabra}");
    }
}
ahorcado();