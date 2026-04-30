using System.Reflection.PortableExecutable;
void ejercicio1()
{
    string vocales = ("aeiouAEIOU");
    string texto = Console.ReadLine();
    int aux = 0;
    foreach (char t in texto)
    {
        foreach (char v in vocales)
        {
            if (v == t)
            {
                aux = aux + 1;
                Console.WriteLine(aux);
                break;
            }
        }
    }
}


void ejercicio2()
{
    Console.WriteLine("Ingrese una palabra.");
    string pala = Console.ReadLine();

    for (int i = pala.Length - 1; i >= 0; i--)
    {
        char letraActual = pala[i];
        Console.Write(letraActual);
    }




}


void ejercicio3()
{
    Console.WriteLine("Ingrese un numero.");
    string texto = Console.ReadLine();
    int aux = 0;
    int aux2 = 0;

    foreach (char V in texto)
    {
        aux2 = Convert.ToInt32("" + V);
        aux = aux + aux2;
    }
    Console.WriteLine(aux);


}

void ejercicio4()
{
    Console.WriteLine("Ingrese la palabra prohibida.");
    string A = Console.ReadLine();
    Console.WriteLine("Ingrese la palabra de reemplazo.");
    string C = Console.ReadLine();
    Console.WriteLine("Ingrese un texto cualquiera.");
    string D = Console.ReadLine();
    string nuevaPALA = D.Replace(A, C);
    Console.WriteLine(nuevaPALA);
}

void ejercicio6()
{
    Console.WriteLine(" Ingrese una palabra:");
    string x = Console.ReadLine();
    bool palin = false;
    foreach (char n in x)
    {
        for (int i = x.Length - 1; i >= 0; i--)
        {
            char letraActual = x[i];

            if (letraActual == n)
            {
                palin = true;


            }
            else
            {
                palin = false;

            }

        }

    }

    Console.WriteLine(palin);





}

