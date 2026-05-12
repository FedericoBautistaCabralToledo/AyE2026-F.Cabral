using System.Runtime.CompilerServices;

//me olvide como usar el return
void ejercicio2(bool sehace)
{
try
{
        Console.WriteLine("Ingrese numeros, cuando ingrese 0 se termina.");
        int r = Convert.ToInt32(Console.ReadLine());
        int aux;
        if (sehace = true)
        {
            if (r != 0)
            {
                aux = r + r;
                Console.WriteLine(aux);
                return sehace;
            }
            else
            {

            }
        }
    }
catch (System.FormatException)
{
        Console.WriteLine("Ponga un numero.");
    }
}
ejercicio2();


void ejercicio1()
{
    int horas = 45;
    int salario;
    if (horas <= 40)
    {
        salario = 16 * horas;
        Console.WriteLine("Su salario semanal son: ");
        Console.Write("$");
        Console.WriteLine(salario);
    }
    else
    {
        salario = 16 * horas + 20 * (horas - 40);
        Console.WriteLine("Su salario semanal son: ");
        Console.Write("$");
        Console.Write(salario);
    }
}
ejercicio1();


void ejercicio3()
{
    Console.WriteLine("Ingrese una palabra.");
    string palabra = Console.ReadLine();
    string voca = "AEIOUaeiou";
    int aux = 0;
    int aux2 = 0;
    Console.WriteLine("En total hay ");
    foreach (char l in palabra)
    {
        foreach (char i in voca)
        {
            if (l == i)
            {
                aux2 = aux + 1;
                Console.WriteLine(aux2);
            }
        }
    }
    Console.WriteLine("vocales.");
}
ejercicio3();

void ejercicio4()
{
    Console.WriteLine("Ingrese una palabra");
string palabra = Console.ReadLine();
bool sehace3 = false;
if (sehace3 = false)
{
        foreach (char l in palabra)
        {
            for (int i = 0; i == palabra.Length; i--)
            {
                if (l == l)
                {
                    Console.WriteLine("Es palindromo");
                }
            }
        }
    }
}
ejercicio4();