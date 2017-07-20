namespace _04.Telephony.Interfaces
{
    public interface IPhone
    {
        string Model { get; }

        string Call(string phoneNumber);
    }
}
