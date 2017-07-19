namespace _01.Define_an_Interface_IPerson
{
    public interface IPerson : IBirthable
    {
        string Name { get; }

        int Age { get; }
    }
}
