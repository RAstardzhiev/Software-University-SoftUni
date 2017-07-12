public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.name = name;
    }

    public string Name => this.name;

    public abstract int GetAffinity();
}
