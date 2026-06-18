void Evaluacion()
{
    string[] tipo = { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" };
    string[] pokemon = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
    string[,] EquipoRed = new string[5, 2];
    string[,] EquipoBlue = new string[5, 2];
    string[,] EquipoGreen = new string[5, 2];
    string[,] EquipoYellow = new string[5, 2];
    string ganador1;
    string ganador2;
    int ganador1VER;
    int ganador2VER;
    int RendimientoER;
    int RendimientoEY;
    int RendimientoEG;
    int RendimientoEB;
    Random aleatorio = new Random();

    EquipoRed = llenarEquipoRed();
    EquipoBlue = llenarEquipoBlue();
    EquipoGreen = llenarEquipoGreen();
    EquipoYellow = llenarEquipoRed();

    calcularGanadorRG();
    calcularGanadorBY();
    calcularGanadorFINAL();

    string [,] llenarEquipoRed()
    {
        for (int x = 0; x < EquipoRed.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoRed.GetLength(1); y++)
            {
                RendimientoER = aleatorio.Next(50, 80);
                Console.WriteLine(RendimientoER);
            }
        }

        for (int x = 0; x < EquipoRed.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoRed.GetLength(1); y++)
            {
                Console.WriteLine(aleatorio.Next(1, 6));
                Console.WriteLine(tipo(aleatorio));
            }
        }

        for (int x = 0; x < EquipoRed.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoRed.GetLength(1); y++)
            {
                Console.WriteLine(pokemon(aleatorio));
            }
        }
        return llenarEquipoRed();
    }
    llenarEquipoRed();

    string[,] llenarEquipoBlue()
    {
        for (int x = 0; x < EquipoBlue.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoBlue.GetLength(1); y++)
            {
                RendimientoEB = aleatorio.Next(50, 80);
                Console.WriteLine(RendimientoEB);
            }
        }

        for (int x = 0; x < EquipoBlue.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoBlue.GetLength(1); y++)
            {
                Console.WriteLine(aleatorio.Next(1, 6));
                Console.WriteLine(tipo(aleatorio));
            }
        }

        for (int x = 0; x < EquipoBlue.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoBlue.GetLength(1); y++)
            {
                Console.WriteLine(pokemon(aleatorio));
            }
        }
        return llenarEquipoBlue();
    }
    llenarEquipoBlue();

    string[,] llenarEquipoGreen()
    {
        for (int x = 0; x < EquipoGreen.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoGreen.GetLength(1); y++)
            {
                RendimientoEG = aleatorio.Next(50, 80);
                Console.WriteLine(RendimientoEG);
            }
        }

        for (int x = 0; x < EquipoGreen.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoGreen.GetLength(1); y++)
            {
                Console.WriteLine(aleatorio.Next(1, 6));
                Console.WriteLine(tipo(aleatorio));
            }
        }

        for (int x = 0; x < EquipoGreen.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoGreen.GetLength(1); y++)
            {
                Console.WriteLine(pokemon(aleatorio));
            }
        }
        return llenarEquipoGreen();
    }
    llenarEquipoGreen();

    string[,] llenarEquipoYellow()
    {
        for (int x = 0; x < EquipoYellow.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoYellow.GetLength(1); y++)
            {
                RendimientoEY = aleatorio.Next(50, 80);
                Console.WriteLine(RendimientoEY);
            }
        }

        for (int x = 0; x < EquipoYellow.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoYellow.GetLength(1); y++)
            {
                Console.WriteLine(aleatorio.Next(1, 6));
                Console.WriteLine(tipo(aleatorio));
            }
        }

        for (int x = 0; x < EquipoYellow.GetLength(0); x++)
        {
            for (int y = 0; y < EquipoYellow.GetLength(1); y++)
            {
                Console.WriteLine(pokemon(aleatorio));
            }
        }
        return llenarEquipoYellow();
    }
    llenarEquipoYellow();

    void calcularGanadorRG()
    {
        if (RendimientoEG > RendimientoER)
        {
            Console.WriteLine("Gana el equipo verde.");
            ganador1 = "Equipo Verde";

        }
        else if (RendimientoEG < RendimientoER)
        {
            Console.WriteLine("Gana el equipo rojo.");
            ganador2 = "Equipo Rojo";
        }
        else
        {
            Console.WriteLine("Empate.");
        }

    }
    calcularGanadorRG();

    void calcularGanadorBY()
    {
        if (RendimientoEB > RendimientoEY)
        {
            Console.WriteLine("Gana el equipo azul.");
            ganador2 = "Equipo Azul";
            ganador2VER = RendimientoEB;
        }
        else if (RendimientoEB < RendimientoEY)
        {
            Console.WriteLine("Gana el equipo amarillo.");
            ganador2 = "Equipo Amarillo";
            ganador2VER = RendimientoEY;
        }
        else
        {
            Console.WriteLine("Empate.");
        }
    }
    calcularGanadorBY();

    void calcularGanadorFINAL()
    {
        if (ganador2VER > ganador1VER)
        {
            Console.WriteLine("Gana el equipo ");
            Console.WriteLine(ganador2);
        }
        else if (ganador2VER < ganador1VER)
        {
            Console.WriteLine("Gana el equipo ");
            Console.WriteLine(ganador1);
        }
        else
        {
            Console.WriteLine("Empate!");
        }
    }
    calcularGanadorFINAL();

    void recursiva()
    {
        bool test (int numero1)
        {
            if (numero1 == -5)
            {
                return false;
            }
            else
            {
                Console.WriteLine(numero1);
                test(numero1 - 5);
                return true;
            }
        }
    }
    recursiva();
}
Evaluacion();