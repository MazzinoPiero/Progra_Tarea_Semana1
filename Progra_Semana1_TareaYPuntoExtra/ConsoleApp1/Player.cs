internal class Player : Character
{
    protected int experience;
    protected int level;
    public int Experience { get { return experience; } }
    public int Level { get { return level; } }

    public Player(string name) : base(name)
    {
        experience = 0;
        level = 1;
    }
    public void GainExp(int exp)
    {
        experience += exp;
        if (experience >= level * 100)
        {
            level++;
            experience = 0;
            Console.WriteLine($"Haz aumentado de nivel mi querido padawan... wait eso de nuevo es de otra franquicia {level}!");
        }
    }

    public override void ShowStatus()
    {
        Console.WriteLine($"Jugador: {Name}, Nivel: {Level}, Experiencia: {Experience}");
    }
}