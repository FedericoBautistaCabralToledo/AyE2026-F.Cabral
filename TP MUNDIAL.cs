namespace ConsoleApp1
{
    public struct Jugador
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public int Cant_goles { get; set; }

        public int Cant_disparos_arco { get; set; }

        public int Numero_camiseta { get; set; }

        public string Posicion { get; set; }

        public string[] Equipo { get; set; }

        public Jugador(string nombre, string apellido, int cant_goles, int cant_disparos_arco, int numero_camiseta, string posicion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cant_goles = cant_goles;
            Cant_disparos_arco = cant_disparos_arco;
            Numero_camiseta = numero_camiseta;
            Posicion = posicion;
            Equipo = new string[10];
        }
    }
    internal class Program
    {
        int indice_ataque = 0;
        double max_indice = 0;
        static void Main(string[] args)
        {
            Jugador[] equipo = new Jugador[10];
            equipo[0] = new Jugador("Thibaut", "Courtois", 8, 4, 1, "Portero");
            equipo[1] = new Jugador("Achraf", "Hakimi", 7, 10, 2, "Defensa");
            equipo[2] = new Jugador("Virgil", "van Dijk", 8, 8, 4, "Defensa");
            equipo[3] = new Jugador("William", "Saliba", 7, 7, 2, "Defensa");
            equipo[4] = new Jugador("Alfonso", "Davies", 6, 9, 19, "Defensa");
            equipo[5] = new Jugador("Rodri", "Hernández", 9, 15, 16, "Mediocampista");
            equipo[6] = new Jugador("Kevin", "De Bruyne", 8, 22, 17, "Mediocampista");
            equipo[7] = new Jugador("Jamal", "Musiala", 7, 18, 42, "Mediocampista");
            equipo[8] = new Jugador("Mohamed", "Salah", 8, 28, 11, "Delantero");
            equipo[9] = new Jugador("Lamine", "Yamal", 7, 16, 19, "Delantero");

            Jugador mejor = Ver_mejor_jugador(equipo);
            double mejor_indice = GenerarIndiceAtaque(mejor.Cant_goles, mejor.Cant_disparos_arco);
            Console.WriteLine($"El jugador con mayor indice de ataque es: {mejor.Nombre} {mejor.Apellido} Posicion: {mejor.Posicion} #{mejor.Numero_camiseta} Disparos al arco:{mejor.Cant_disparos_arco} Goles:{mejor.Cant_goles} Indice ataque: {mejor_indice:F2}");
        }
        static double GenerarIndiceAtaque(int Cant_goles, int Cant_disparos_arco)
        {
            if (Cant_disparos_arco == 0) { return 0; }
            return ((double)Cant_goles / Cant_disparos_arco) * 100;
        }

        static Jugador Ver_mejor_jugador(Jugador[] equipo)
        {
            Jugador mejorJUGA = equipo[0];
            double indiceMAX = GenerarIndiceAtaque(equipo[0].Cant_goles, equipo[0].Cant_disparos_arco);
            for (int i = 1; i < equipo.Length; i++)
            {
                double IndiceActual = GenerarIndiceAtaque(equipo[i].Cant_goles, equipo[i].Cant_disparos_arco);

                if (IndiceActual > indiceMAX)
                {
                    indiceMAX = IndiceActual;
                    mejorJUGA = equipo[i];
                }
            }
            return mejorJUGA;
        }
    }
}