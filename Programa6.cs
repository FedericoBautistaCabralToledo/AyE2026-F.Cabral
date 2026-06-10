   void Programa6()
   {
   try
   {
        string[,] matrizVisual = new string[10, 10];
        for (int fila = 0; fila < matrizVisual.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matrizVisual.GetLength(1); columna++)
            {
                matrizVisual[fila, columna] = "X" + " ";
            }
        }

        int[,] matriz1 = new int[10, 10];

        int unos = 0;

        int intentos = 5;

        bool adivinar = true;

        int adivinados = 0;

        int ultimaX = -1;
        int ultimaY = -1;

        Random num = new Random();

        while (unos < 3)
        {
            int fila = num.Next(0, 10);
            int columna = num.Next(0, 10);

            if (matriz1[fila, columna] == 0)
            {
                matriz1[fila, columna] = 1;
                unos++;
            }
        }

        for (int fila = 0; fila < matriz1.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz1.GetLength(1); columna++)
            {
                Console.Write("X" + " ");
            }
            Console.WriteLine();
        }

        while (adivinar == true)
        {
            Console.WriteLine("Elija la casilla en la cordenada x del 1 al 10.");
            int corx = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("Elija la casilla en la cordenada y del 1 al 10.");
            int cory = Convert.ToInt32(Console.ReadLine()) - 1;

            ultimaX = corx;
            ultimaY = cory;

            if (matriz1[corx, cory] == 1)
            {
                Console.WriteLine("Usted acerto.");
                adivinados++;

                matrizVisual[corx, cory] = "O";

                for (int fila = 0; fila < matrizVisual.GetLength(0); fila++)
                {
                    for (int columna = 0; columna < matrizVisual.GetLength(1); columna++)
                    {
                        Console.Write(matrizVisual[fila, columna] + " ");
                    }
                    Console.WriteLine();
                }

                if (adivinados == 3)
                {
                    Console.WriteLine("Usted ganó.");

                    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
                    {
                        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
                        {
                            Console.WriteLine(matriz1[fila, columna] + " ");
                        }
                        Console.WriteLine();
                    }
                    adivinar = false;
                    break;
                }
            }
            else
            {
                intentos--;
                Console.WriteLine($"{intentos} intentos restantes.");

                matrizVisual[corx, cory] = "0";

                for (int fila = 0; fila < matrizVisual.GetLength(0); fila++)
                {
                    for (int columna = 0; columna < matrizVisual.GetLength(1); columna++)
                    {
                        Console.Write(matrizVisual[fila, columna] + " ");
                    }
                    Console.WriteLine();
                }
                if (intentos == 0)
                {
                    Console.WriteLine("Perdio, los tesoros eran: ");

                    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
                    {
                        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
                        {
                            Console.Write(matriz1[fila, columna] + " ");
                        }
                        Console.WriteLine();
                    }
                    adivinar = false;
                    break;
                }
            }
        }
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Formato erroneo.");
    }
}
Programa6();
