using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private const string CommandSuffix = "Command";

    private IInputReader reader;
    private IOutputWriter writer;
    private IHeroManager heroManager;
    ICommandManager commandManager;

    public Engine(IInputReader reader, 
        IOutputWriter writer, 
        IHeroManager heroManager, 
        ICommandManager commandManager)
    {
        this.reader = reader;
        this.writer = writer;
        this.heroManager = heroManager;
        this.commandManager = commandManager;
    }

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            List<string> inputArgs = this.reader.ReadLine()
                .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (inputArgs[0].Equals("Quit", StringComparison.OrdinalIgnoreCase))
            {
                isRunning = false;
            }

            string commandResult = this.ProcessInput(inputArgs);
            this.writer.WriteLine(commandResult);
        }
    }

    private string ProcessInput(IList<string> arguments)
    {
        string commandName = arguments[0] + CommandSuffix;
        arguments.RemoveAt(0);

        return this.commandManager.ProcessCommand(commandName, arguments);
    }
}