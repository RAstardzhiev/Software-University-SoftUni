namespace _2.Cars.Cars.Abstraction
{
    public interface ICar
    {
        string Model { get; }

        string Color { get; }

        string Start();

        string Stop();
    }
}
