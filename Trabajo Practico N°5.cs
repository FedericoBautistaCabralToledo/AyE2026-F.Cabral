void ejercicio1()
{
    string contra = "12345";

    Console.WriteLine("Ingrese la contraseña.");
    string adivin = Console.ReadLine();

    while (adivin != contra)
    {
        Console.WriteLine("Intentelo denuevo");
        adivin = Console.ReadLine();

    }
    Console.WriteLine("entrando");
}
ejercicio1();


void ejercicio2()
{
    int cont = 5;

    while (cont > 0)

    {
        Console.WriteLine(cont);
        cont--;
    }
    Console.WriteLine("¡Despegue!");
}
ejercicio2();

void ejercicio3()
{
    int secreto = 7;

    Console.WriteLine("Adivina el numero del 1-10.");
    int adiv = Convert.ToInt32(Console.ReadLine());
    while (adiv != secreto)
    {
        Console.WriteLine("Incorrecto, intenta denuevo.");
        adiv = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Adivinaste el numero.");

}
ejercicio3();

void ejercicio4()
{
    int numero = 1;
    int suma = 0;
    while (numero != 0)
    {
        Console.WriteLine("Ingrese un numero para sumar. (Ingrese 0 para finalizar)");
        numero = Convert.ToInt32(Console.ReadLine());

        suma = suma + numero;
    }
    Console.WriteLine("La suma total de los numeros ingresados es " + suma);
}
ejercicio4();
