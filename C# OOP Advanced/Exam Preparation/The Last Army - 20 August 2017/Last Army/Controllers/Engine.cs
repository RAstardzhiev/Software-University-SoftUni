using System;
using System.Text;

public class Engine
{
    private IReader reader;
    private IWriter writer;
    private IGameController gameController;
    private MissionController missionController;

    public Engine(IReader reader, IWriter writer, IGameController gameController, MissionController missionController)
    {
        this.reader = reader;
        this.writer = writer;
        this.gameController = gameController;
        this.missionController = missionController;
    }

    public void Run()
    {
        var input = this.reader.ReadLine();
        var result = new StringBuilder();

        while (!input.Equals("Enough! Pull back!"))
        {
            try
            {
                this.gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message.Trim());
            }

            input = this.reader.ReadLine();
        }

        result.AppendLine(this.gameController.ToString().Trim());
        this.writer.WriteLine(result.ToString().Trim());
    }
}
