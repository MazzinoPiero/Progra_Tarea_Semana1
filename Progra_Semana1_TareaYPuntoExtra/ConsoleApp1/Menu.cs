internal class Menu : IMenu
{
    private Player player;
    private Dictionary<int, string> decisions = new Dictionary<int, string>()
    {
        { 1, "Esconderse en un Castillo Oscuro" },
        { 2, "Dormirte en el nido de un dragon" },
        { 3, "Escuchar a la ninfa de agua" },
        { 4, "Atrapar dementores (Pd: son simples fantasmas)" },
        { 5, "Subirte a una mantaraya voladora" }
    };

    public void Execute()
    {
        CreatePlayer();
        ShowMenu();
    }

    private void CreatePlayer()
    {
        Console.WriteLine("Escribe el nombre para tu jugador:");
        string name = Console.ReadLine();
        player = new Player(name);

        Console.WriteLine($"Jugador {player.Name} creado con nivel {player.Level} y {player.Experience} de experiencia.");
    }

    private void ShowMenu()
    {
        bool continueFlag = true;
        while (continueFlag)
        {
            Console.WriteLine("Elige una opción:");
            foreach (var decision in decisions)
            {
                Console.WriteLine($"{decision.Key}: {decision.Value}");
            }
            Console.WriteLine("0: Salir");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Al ingresar al castillo y encontraste una esfera que te otorgó el poder de ser inmune a los poderes de luz. Eso fue suerte I guess.");
                        player.GainExp(50);
                        break;
                    case 2:
                        Console.WriteLine("Dormiste y roncaste como una locomotora.");
                        break;
                    case 3:
                        Console.WriteLine("La ninfa intento seducirte, pero fracazó.");
                        break;
                    case 4:
                        Console.WriteLine("Lograste atrapar a todos los fantasmas! Ejem... Dementores? Chapa tu experiencia.");
                        player.GainExp(100);
                        break;
                    case 5:
                        Console.WriteLine("Saliste volando hacia una tormenta, que daria inicio a nuevas aventuras.");
                        break;
                    case 0:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no valida.");
                        break;
                }
                player.ShowStatus();
            }
            else
            {
                Console.WriteLine("Ingresa un número válido.");
            }
        }
    }
}