using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class CommandManager : ICommandManager
{
    private const string InvalidCommandNameExceptionMessage = "Command {0} doesn't exists!";

    private IHeroManager heroManager;
    private Type[] commandTypes;

    public CommandManager(IHeroManager heroManager)
        : this(heroManager, new TypeCollector())
    {
    }

    public CommandManager(IHeroManager heroManager, ITypeCollector typecollector)
        : this(heroManager, typecollector.GetAllInheritingTypes<ICommand>())
    {
    }

    public CommandManager(IHeroManager heroManager, Type[] allCommands)
    {
        this.heroManager = heroManager;
        this.commandTypes = allCommands;
    }

    public string ProcessCommand(string cmdName, IList<string> cmdArgs)
    {
        Type command = this.commandTypes
            .FirstOrDefault(ct => ct.Name.Equals(cmdName, StringComparison.OrdinalIgnoreCase));

        if (command == null)
        {
            throw new ArgumentException(string.Format(InvalidCommandNameExceptionMessage, cmdName));
        }
        ConstructorInfo ctor = command.GetConstructor(new Type[] { cmdArgs.GetType(), this.heroManager.GetType() });
        ICommand commandInstance = (ICommand)ctor.Invoke(new object[] { cmdArgs, this.heroManager });
        return commandInstance.Execute();
    }
}
