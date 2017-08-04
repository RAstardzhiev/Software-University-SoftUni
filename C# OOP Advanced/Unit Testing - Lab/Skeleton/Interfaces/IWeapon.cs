namespace Skeleton.Interfaces
{
    public interface IWeapon
    {
        int AttackPoints { get; }

        int DurabilityPoints { get; }

        void Attack(ITarget target);
    }
}
