using System.Reflection;

void Ejercicio1()
{
    for (int num = 1; num < 11; num++)
    {
        Console.WriteLine(num);
    }
   
}
Ejercicio1();

void Ejercicio2()
{
 for (int num = 0; num < 5; num++)
    {
        Console.WriteLine("¡Hola Mundo!");
    }
}
Ejercicio2();

void Ejercicio3()
{
    for (int num = 2; num  < 21;num += 2)
    {
        Console.WriteLine(num);
    }
}
Ejercicio3();

Console.WriteLine("--------------------");
void Ejercicio4()
{
    for (int num = 7; num < 71; num +=7)
    {
        Console.WriteLine(num);
    }
}
Ejercicio4();

Console.WriteLine("--------------------");

void Ejercicio5()
{
    int testc = 0;
    for (int num = 0; num < 6; num += 1)
    { 
        Console.WriteLine(testc += num);
    }
}
Ejercicio5();