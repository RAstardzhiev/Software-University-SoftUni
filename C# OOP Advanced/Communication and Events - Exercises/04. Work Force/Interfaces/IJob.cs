namespace _04.Work_Force.Interfaces
{
    using Models;

    public interface IJob
    {
        event JobDoneEventHandler JobDone;

        string Name { get; }

        int RequiredHoursOfWork { get; }

        void Update();
    }
}
