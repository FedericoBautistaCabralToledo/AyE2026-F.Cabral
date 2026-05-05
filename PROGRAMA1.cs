string abc = "abcdefghijklmnñopqrstuvwxyz ";
Funcion2();

string Funcion1()
{
    bool esValido = false;
    string mensaje = "";

    while (!esValido)
    {
        Console.WriteLine("Ingrese el mensaje:");
        mensaje = Console.ReadLine().ToLower();

        bool error = false;

        foreach (char MensajeLetras in mensaje)
        {

            if (abc.IndexOf(MensajeLetras) == -1)
            {
                error = true;
                break;
            }
        }
        if (error)
        {
            Console.Write("Contiene caracteres no permitidos.");
        }
        else
        {
            esValido = true;
        }
    }
    return mensaje;
}

void Cifrar(string texto, string abc)
{
    Console.WriteLine("Ingrese la clave.");
    int clave = Convert.ToInt32(Console.ReadLine());

    string resultado = "";
    foreach (char q in texto)
    {
        int pos = abc.IndexOf(q);
        int nuevacon = (pos + clave) % abc.Length;
        if (nuevacon < 0) nuevacon += abc.Length;
        resultado += abc[nuevacon];
    }
    Console.WriteLine("Cifrado: " + resultado);
}

void Descifrar(string texto, string abc)
{
    Console.WriteLine("Ingrese la clave: ");
    int clave = Convert.ToInt32(Console.ReadLine());

    string resultado = "";
    foreach (char c in texto)
    {
        int pos = abc.IndexOf(c);
        int nuevaPos = (pos - clave) % abc.Length;
        if (nuevaPos < 0) nuevaPos += abc.Length;
        resultado += abc[nuevaPos];
    }
    Console.WriteLine("Su texto descifrado es: " + resultado);
}

void Funcion2()
{
    string texto = Funcion1();
    bool ejecutando = true;

    while (ejecutando)
    {
        Console.WriteLine("1- Cifrar 2- Descifrar");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Cifrar(texto, abc);
                break;
            case 2:
                Descifrar(texto, abc);
                break;
            default:
                Console.WriteLine("Numero invalido.");
                break;
        }
    }
}