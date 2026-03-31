string Ejercicio1(int Num){
    string res;
    if (Num > 0)
    {
        res = "El número es positivo.";
        return res;
    }
    else if (Num < 0)
    {
        res=("El número es negativo.");
        return res;
    }
    else
    {
        res=("El número es cero.");
        return res;
    }
}
Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));

string Ejercicio2(int edad) {
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

string Ejercicio3(string contra)
{
    string mensaje;
    if (contra = "python123")
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

string Ejercicio4(int numer)
{
    string res;
    if (numer % 2==0)
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

string Ejercicio5(int edad)
{
    string res;
    Console.WriteLine("Compra pochoclos?");
    string pochoc = Console.ReadLine();
    if (edad >= 65 && pochoc == "si")
    {
        res = ("Felicidades! Tiene entrada gratuita al cine.");
        return res;
    }
    else
    {
        res = ("Compra la entrada o raja de aca.");
        return res;
    }
}
Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));
