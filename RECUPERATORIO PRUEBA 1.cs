int ejercicio1(int horas)
{
    horas = 50;
    int aux = 0;
    int salario = 32;
    
    if (horas <= 40)
    {
        salario = horas * 16;
        Console.WriteLine("Su salario es: " + salario);
        return salario;
    }

    else if (horas > 40)
    {
        salario = 40 * 16;
        aux = 40 - horas * 20;
        salario = salario + aux;
        Console.WriteLine("Su salario es: " + salario);
    }
    return salario;
}
ejercicio1();

try
{
    int ejercicio2()
    {
        Console.WriteLine("Ingrese numeros. Cuando ingrese 0 se van a sumar y dara el resultado.");
        int numero = Convert.ToInt32(Console.ReadLine());
        bool sigue = true;
        int auxSUMA = 0;

        while (sigue == true)
        {
            if (numero != 0)
            {
                auxSUMA = auxSUMA + numero;
            }
            else if (numero == 0)
            {
                Console.WriteLine("Ingreso 0. La suma de los numeros que ingreso es: " + auxSUMA);
            }
        }
        return auxSUMA;
    }
    ejercicio2();
}
catch (FormatException)
{
    Console.WriteLine("Ingrese un numero.");
}

try
{
    int ejercicio3()
    {
        Console.WriteLine("Ingrese una palabra.");
        string palabra = Console.ReadLine();
        string vocales = "aeiouAEIOU";
        int aux = 0;

        foreach (char P in palabra)
        {
            foreach (char V in vocales)
            {
                if (V == P)
                {
                    aux += 1;
                    Console.WriteLine("La cantidad de vocales que tiene la palabra son: " + aux);
                }
            }
        }
        return aux;
    }
    ejercicio3();
}
catch (FormatException)
{
    Console.WriteLine("Ingrese una palabra (string).");
}

try
{
    string ejercicio4()
    {
        Console.WriteLine("Ingrese una palabra.");
        bool Ejecuta = true;
        string palabra = Console.ReadLine();

        while (Ejecuta == true)
        {
            foreach (char L in palabra)
            {
                for (int i = palabra.Length - 1; palabra.Length >= 0; i--)
                {

                    if (palabra[i] == palabra.Length)
                    {
                        Console.WriteLine("La palabra si es un palindromo.");
                        Console.WriteLine("La palabra que usted eligio fue: " + palabra);
                        Ejecuta = false;
                    }
                    else
                    {
                        Console.WriteLine("La palabra no es un palindromo.");
                        Console.WriteLine("La palabra que usted eligio fue: " + palabra);
                        Ejecuta = true;
                    }
                }
            }

        }
        return palabra;
    }
    ejercicio4();
}
catch (FormatException)
{
    Console.WriteLine("Ingrese una palabra (string).");
}