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

string Ejercicio3(string contra) {
    string mensaje;
    if (contra = "python123")
    {
        mensaje = "¡Contraseña Correcta! Acceso concedido.";
        return mensaje;
    
    }