namespace _02.Blobs.Interfaces
{
    public interface IAttack
    {
        void Execute(IBlob attacker, IBlob target);
    }
}