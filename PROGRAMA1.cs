void Programa1()
{
    int aux = 1;
    int intentos = 0;
    bool ejecuta = true;

    while (intentos < 3)
    {
        Console.WriteLine("Ingrese un numero entero positivo sin caracteres especiales, tiene 3 intentos.");
        int numeFactorial = Convert.ToInt32(Console.ReadLine());

        intentos++;

        if (intentos >= 3)
        {
            Console.WriteLine("No tiene mas intentos.");
            break;
        }
        if (numeFactorial < 0)
        {
            Console.WriteLine("Ingrese numeros positivos. Numeros de intentos: " + intentos);
        }
        else if (numeFactorial > 0)
        {
            for (int num = 1; num <= numeFactorial; num++)
            {
                aux*= num;
            }
            Console.WriteLine("El factorial de su numero es: " ,aux);
            ejecuta = false;
            if (ejecuta== false)
            {
            }
        }
    }
}
Programa1();