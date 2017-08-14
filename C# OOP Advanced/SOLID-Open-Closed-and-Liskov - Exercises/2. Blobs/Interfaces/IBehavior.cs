namespace _02.Blobs.Interfaces
{
    public interface IBehavior
    {
        bool IsTriggered { get; }

        void Trigger(IBlob blob);

        void ApplyRecurrentEffect(IBlob blob);
    }
}