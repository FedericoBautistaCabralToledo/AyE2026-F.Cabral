using System;

class Program
{
    class Personaje
    {
        public string Nombre { get; set; }
        public int Poder { get; set; }
        public string[] Items { get; set; } = new string[20];
        public int CantidadItems { get; set; } = 0;
    }

    class Sala
    {
        public int Dificultad { get; set; }
        public string Item { get; set; }
        public int PoderItem { get; set; }
    }

    static void Main(string[] args)
    {
        Random rand = new Random();
        string[] bancoItems = { "Armadura", "Arma", "Poción", "Amuleto" };

        Personaje p1 = new Personaje { Nombre = "el capo", Poder = 25 };
        Personaje p2 = new Personaje { Nombre = "MASTER", Poder = 25 };

        int turnosTotales = 0;

        while (turnosTotales < 20)
        {
            Personaje personajeActual = (turnosTotales % 2 == 0) ? p1 : p2;
            Console.WriteLine($"Turno {turnosTotales + 1}: Es el turno de {personajeActual.Nombre}");

            Sala salaActual = new Sala
            {
                Dificultad = rand.Next(1, 100),
                Item = bancoItems[rand.Next(bancoItems.Length)],
                PoderItem = rand.Next(1, 100)
            };

            Console.WriteLine($"Entrando a sala. Dificultad: {salaActual.Dificultad} - Item disponible: {salaActual.Item} + {salaActual.PoderItem} Poder");
            Console.WriteLine($"Poder actual de {personajeActual.Nombre}: {personajeActual.Poder}");

            if (salaActual.Dificultad < personajeActual.Poder)
            {
                personajeActual.Items[personajeActual.CantidadItems] = salaActual.Item;
                personajeActual.CantidadItems++;

                personajeActual.Poder += salaActual.PoderItem;
                Console.WriteLine($"{personajeActual.Nombre} robo {salaActual.Item}. Nuevo poder: {personajeActual.Poder}");
            }
            else
            {
                Console.WriteLine("No se roba porque la dificultad es muy alta.");
            }
            turnosTotales++;
            Console.WriteLine();
        }
        Console.WriteLine("El juego termino.");

        if (p1.Poder > p2.Poder)
        {
            Console.WriteLine($"El ganador es {p1.Nombre} con un poder de: {p1.Poder}");
            Console.WriteLine($"Los items de {p1.Nombre} son: {UnirItems(p1)}");
        }
        else if (p2.Poder > p1.Poder)
        {
            Console.WriteLine($"El ganador es {p2.Nombre} con un poder de: {p2.Poder}");
            Console.WriteLine($"Los items de {p2.Nombre} son: {UnirItems(p2)}");
        }
        else if (p1.Poder == p2.Poder)
        {
            Console.WriteLine($"Empate.");
            Console.WriteLine($"Ítems de {p1.Nombre}: {UnirItems(p1)}");
            Console.WriteLine($"Ítems de {p2.Nombre}: {UnirItems(p2)}");
        }
    }

    static string UnirItems(Personaje p)
    {
        if (p.CantidadItems == 0) return "Ninguno";

        string resultado = "";

        for (int i = 0; i < p.CantidadItems; i++)
        {
            resultado += p.Items[i];
            if (i < p.CantidadItems - 1)
            {
                resultado += ", ";
            }
        }
        return resultado;
    }
}
