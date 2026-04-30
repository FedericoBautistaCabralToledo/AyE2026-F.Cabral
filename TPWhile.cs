void ejercicio1()
{
    bool test = true;
    Console.WriteLine("Ingrese 0 o 1.");
    {
        while (test == true)
        {
            int ingre = Convert.ToInt32(Console.ReadLine());
            if (ingre != 0 && ingre != 1)
            {
                Console.WriteLine("Intente denuevo");
            }
            else
            {
                test = false;
            }
        }
    }
}

void ejercicio2()
{
    Console.WriteLine("Ingrese un numero de 2 cifras.");
    bool test2 = true;
    {
        while (test2 == true)
        {
            int ingre2 = Convert.ToInt32(Console.ReadLine());
            if (ingre2 > 99 || ingre2 < 10)
            {
                Console.WriteLine("Intente denuevo.");
            }
            else
            {
                Console.WriteLine("Gracias.");
                test2 = false;
            }
        }
    }

}
ejercicio2();
