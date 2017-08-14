namespace _02.Blobs.Interfaces
{
    public interface IBlob
    {
        string Name { get; }

        int Health { get; }

        int Damage { get; }

        IBehavior Behavior { get; }

        IAttack Attack { get; }

        bool IsTriggerMessageAvailable { get; set; }

        void TakeAttack(int damage);

        void TriggerBehavior();

        void MakeATurn();
    }
}
