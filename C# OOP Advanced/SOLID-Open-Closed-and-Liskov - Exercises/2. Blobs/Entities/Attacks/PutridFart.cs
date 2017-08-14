namespace _02.Blobs.Entities.Attacks
{
    using Interfaces;

    public class PutridFart : IAttack
    {
        public void Execute(IBlob attacker, IBlob target) => target.TakeAttack(attacker.Damage);
    }
}