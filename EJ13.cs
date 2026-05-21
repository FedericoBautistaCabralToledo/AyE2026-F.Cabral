void Ej1()
{
    string[] nombres = { "Manolo", "Juan", "Mati", "Thiago", "Bian", "Master", "Soni", "Darts", "Soc", "Ven" };
    string palabragrande = "";

    foreach (string n in nombres)
    {
        if (n.Length > palabragrande.Length)
        {

            palabragrande += n;
        }
    }

    Console.WriteLine("Palabra grande " + palabragrande);
}
Ej1();


void Ej2()
{
    int test = 0;
    string vocal = "AEIOUaeiou";
    string[] nombres = { "Manolo", "Juan", "Mati", "Thiago", "Bian", "Master", "Soni", "Darts", "Soc", "Ven" };

    foreach (string n in nombres)
    {
        foreach (char o in n)
        {
            foreach (char K in vocal)
            {
                if (K == o)
                {
                    test++;
                }

            }
        }
    }
    Console.WriteLine("Total de vocales: " + test);
}
Ej2();

void ej3()
{
int[] listanum = { 1, 2, 3 };

int factor = 3;

int[] numeros2 = new int[3];

Console.WriteLine("Numeros: ");
foreach (int e in listanum)
{
    Console.WriteLine(e);
}

Console.WriteLine("Numeros multiplicados por el factor: ");
for (int u = 0; u < listanum.Length; u++)
{
    numeros2[u] = listanum[u] * factor;
    Console.WriteLine(numeros2[u]);
}
}
ej3();