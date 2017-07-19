namespace _03.Ferrari.Cars
{
    public interface ICar
    {
        string Model { get; }

        string Driver { get; }

        string Brakes();

        string Gas();
    }
}
