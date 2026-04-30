try
{
    string Ejercicio1(int Num)
    {
        string res;
        if (Num > 0)
        {
            res = "El número es positivo.";
            return res;
        }
        else if (Num < 0)
        {
            res = ("El número es negativo.");
            return res;
        }
        else
        {
            res = ("El número es cero.");
            return res;
        }
    }
    Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));
}
catch (FormatException)
{
    Console.WriteLine("Tenes que ingresar un numero pa.");
}
catch (OverflowException)
{
    Console.WriteLine("El numero es re grande o re chico.");
}

try
{
    string Ejercicio2(int edad)
    {
        string edadtotal;
        if (edad >= 18)
        {
            edadtotal = "¡Bienvenido a la fiesta!";
            return edadtotal;
        }
        else
        {
            edadtotal = "Lo siento, eres muy joven.";
            return edadtotal;
        }
    }
    Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));
}
catch (System.OverflowException)
{
    Console.WriteLine("El numero es muy grande.");
}
catch (FormatException)
{
    Console.WriteLine("Pone un numero campeon.");
}

string Ejercicio3(string contra)
{
    string mensaje;
    if (contra == "python123")
    {
        mensaje = "¡Contraseña Correcta! Acceso concedido.";
        return mensaje;

    }
    else
    {
        mensaje = "¡Contraseña Incorrecta! Autodestrucción en 5 minutos!";
        return mensaje;
    }
}
Console.WriteLine(Ejercicio3(Console.ReadLine()));

try
{
    string Ejercicio4(int numer)
    {
        string res;
        if (numer % 2 == 0)
        {
            res = "El numero es par.";
            return res;

        }
        else
        {
            res = "El numero es impar.";
            return res;
        }
    }
    Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));
}
catch (FormatException)
{
    Console.WriteLine("Escribi un numero.");
}
catch (OverflowException)
{
    Console.WriteLine("El numero es muy grande o muy chico para el Int32.");
}
