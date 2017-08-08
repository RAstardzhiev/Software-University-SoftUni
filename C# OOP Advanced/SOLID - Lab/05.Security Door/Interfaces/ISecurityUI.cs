namespace _05.Security_Door
{
    using Interfaces;

    public interface ISecurityUI : IKeyCardUI, IPinCodeUI
    {
    }
}