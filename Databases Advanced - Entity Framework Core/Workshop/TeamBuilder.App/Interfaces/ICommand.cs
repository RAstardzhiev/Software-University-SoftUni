namespace TeamBuilder.App.Interfaces
{
    using TeamBuilder.Data;

    public interface ICommand
    {
        string[] CmdArgs { get; }

        IUserSession Session { get; }

        string Execute(TeamBuilderContext context);
    }
}
