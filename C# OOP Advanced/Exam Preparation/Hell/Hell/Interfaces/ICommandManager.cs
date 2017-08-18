using System.Collections.Generic;

public interface ICommandManager
{
    string ProcessCommand(string cmdName, IList<string> cmdArgs);
}
