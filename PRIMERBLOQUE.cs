void ejercicioA()
{
    for (int num = 0; num < 100; num += 3)
    {
        Console.WriteLine(num);
    }
}

void ejercicioB()
{
    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());
    {

        if (edad >= 18)
        {

            Console.WriteLine("Es mayor de edad.");
        }
        else
        {
            Console.WriteLine("No es mayor de edad.");
        }
    }

}

void EjercicioC()
{
    Console.WriteLine("Ingrese un texto.");
    string texto = Console.ReadLine();
    Console.WriteLine("El texto tiene ");
    Console.Write(texto.Length);
    Console.Write(" caracteres");
}

void ejercicioD()
{
    Console.WriteLine("Adivine la contraseña, tiene 5 intentos.");
    for (int intentos = 5; intentos > 0; intentos--)
    {
        string contra = "hola124";
        string contraPuesta = Console.ReadLine();
        if (contra == contraPuesta)
        {
            Console.WriteLine("Adivinaste");
            break;
        }
        else if (intentos == 1)
        {
            Console.WriteLine("No adivinaste");
        }
    }
}

void ejercicioE()
{
    Console.WriteLine("Ingrese un número:");
    int mayor = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= 10; i++)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > mayor)
        {
            mayor = numero;
        }
    }

    Console.WriteLine("El número más alto es " + mayor);
}

void ejercicioF()
{
    Console.WriteLine("Escriba su nombre.");

    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese que cantidad de letras de su nombre quiere mostrar en mayuscula.");
    int numeroparte = (Convert.ToInt32(Console.ReadLine()));

    string parte = nombre.Substring(0, numeroparte);
    string partemayu = parte.ToUpper();
    Console.WriteLine(partemayu);

}

void ejercicioG()
{
    for (int tala = 7; tala < 71; tala += 7)
        Console.WriteLine(tala);
}


void ejercicioH()
{
    for (int cuenta = 1; cuenta < 11; cuenta++)
        Console.WriteLine(cuenta);
    Console.WriteLine("oa");
}

void EjercicioI()
{
    Console.WriteLine("Ingrese un numero");
    int numer = Convert.ToInt32(Console.ReadLine());

    if (numer % 2 == 0)
    {
        Console.WriteLine("Es par");

    }
    else
    {
        Console.WriteLine("Es impar");
    }
}
void EjercicioJ()
{
    Console.WriteLine("Ingrese una frase");
    string frase = Console.ReadLine();
    string vocal = "AEIOUaeiou";
    int test = 0;
    foreach (char T in frase)
    {
        foreach (char I in vocal)
        {
            if (T == I)
            {
                test = test + 1;
                Console.WriteLine(test);
                break;
            }
        }
    }
}

void ejercicioK()
{

    Console.WriteLine("Ingrese un numero");
    int num = Convert.ToInt32(Console.ReadLine());
    int res;
    for (int x = num; x <= 12; x++)
    {
        res = num * x;
        Console.WriteLine(res);
    }
}

void ejercicioL()
{
    Console.WriteLine("Ingrese numeros de a uno, el programa para cuando todos los numeros combinados sean mayor a 100.");
    int numero;
    for (int testNAM = 0; testNAM < 100; testNAM += numero)
    {
        numero = Convert.ToInt32(Console.ReadLine());
        if (testNAM < 100)
        {

        }
        else if (testNAM > 100)
        {
            break;
        }
    }
}

void ejercicioM()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    for (int t = 0; t < palabra.Length; t++)
    {
        char Letra = palabra[t];
        Console.WriteLine(Letra);
    }
}

void ejercicioN()
{
    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad >= 17)
    {

        Console.WriteLine("Puede manejar.");

    }

    if (edad >= 16)
    {
        Console.WriteLine("Puede votar.");
    }

    if (edad < 17)
    {
        Console.WriteLine("No puede manejar");
    }

    if (edad < 16)
    {
        Console.WriteLine("No puede votar.");
    }
}

void ejercicioO()
{
    for (int desc = 50; desc > 1; desc -= 5)
    {
        Console.WriteLine(desc);
    }
}

void ejercicioP()
{
    bool EJP = true;
    while (EJP == true)
    {
        Console.WriteLine("Escriba la contraseña.");
        string contraP = Console.ReadLine();
        Console.WriteLine("Escriba la misma contraseña denuevo.");
        string contraP2 = Console.ReadLine();
        if (contraP == contraP2)
        {
            Console.WriteLine("Acceso permitido");
            break;
        }
        else
        {
            Console.WriteLine("Intente denuevo.");
            EJP = true;
        }
    }
}

void ejercicioQ()
{
    Console.WriteLine("Ingrese nombres 1x1 no más de 10 caracteres o sino se termina el programa.");
    bool SeEjecuta = false;
    while (SeEjecuta = true)
    {
        string nombre = Console.ReadLine();
        SeEjecuta = false;
        if (nombre.Length > 10)
        {
            Console.WriteLine("Chau");
            break;
        }
    }

}

void ejercicioR()
{
    Console.WriteLine("Ingrese nombres 1x1 no más de 10 caracteres o sino se termina el programa.");
    bool SeEjecuta = false;
    while (SeEjecuta = true)
    {
        string nombre = Console.ReadLine();
        SeEjecuta = false;
        if (nombre.Length > 10)
        {
            Console.WriteLine("Chau");
            break;
        }
    }

}


Console.WriteLine("Ingrese el numero del ejercicio que quiere hacer.");
string ejernum = Console.ReadLine();
string ejernum2 = ejernum.ToUpper();
switch (ejernum2)
{
    case "A":
        ejercicioA();
        break;
    case "B":
        ejercicioB();
        break;
    case "C":
        EjercicioC();
        break;
    case "D":
        ejercicioD();
        break;
    case "E":
        ejercicioE();
        break;
    case "F":
        ejercicioF();
        break;
    case "G":
        ejercicioG();
        break;
    case "H":
        ejercicioH();
        break;
    case "I":
        EjercicioI();
        break;
    case "J":
        EjercicioJ();
        break;
    case "K":
        ejercicioK();
        break;
    case "L":
        ejercicioL();
        break;
    case "M":
        ejercicioM();
        break;
    case "N":
        ejercicioN();
        break;
    case "O":
        ejercicioO();
        break;
    case "P":
        ejercicioP();
        break;
    case "Q":
        ejercicioQ();
        break;
    case "R":
        ejercicioR();
        break;
    default:
        Console.WriteLine("Parametros erroneos, ingrese el numero del ejercicio al cual desea ingresar.");
        ejernum = Console.ReadLine();
        ejernum2 = ejernum2.ToUpper();
        break;
}