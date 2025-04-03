internal abstract class Character
{
    protected string name;
    public string Name { get { return name; } }
    public Character(string name)
    {
        this.name = name;
    }
    public abstract void ShowStatus();
}