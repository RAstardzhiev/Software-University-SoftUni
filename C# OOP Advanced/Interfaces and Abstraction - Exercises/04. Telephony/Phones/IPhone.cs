namespace _04.Telephony.Phones
{
    public interface IPhone
    {
        string Model { get; }

        string Call(string phoneNumber);
    }
}
