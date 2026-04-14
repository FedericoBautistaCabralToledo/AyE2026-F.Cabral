Console.WriteLine
("1- Ejercicio 1. 2- Ejercicio 2. 3- Ejercicio 3. 4- Ejercicio 4. 5- Ejercicio 5. 0- Terminar el programa.");

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

    int X = Convert.ToInt16(Console.ReadLine());

    switch (X)
    {
        case 1:
            Console.WriteLine("Te digo si tu numero es positivo o negativo");
        Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));
            break;

        case 2:
            Console.WriteLine("Decime tu edad y te digo si podes entrar a la fiesta o no");
            Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));
        break;

        case 3:
            Console.WriteLine("Te digo si la contraseña es correcta o no");
            Console.WriteLine(Ejercicio3(Console.ReadLine()));
        break;

        case 4:
            Console.WriteLine("Te digo si tu numero es par o no");
            Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));
            break;

        case 5:
            Console.WriteLine("Te digo si podes entrar gratis al cine o no");
            Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));
            break;

        case 0:
            break;

    }