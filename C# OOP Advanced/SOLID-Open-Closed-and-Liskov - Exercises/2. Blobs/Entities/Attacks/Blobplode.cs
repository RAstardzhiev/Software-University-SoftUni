namespace _02.Blobs.Entities.Attacks
{
    using Interfaces;

    public class Blobplode : IAttack
    {
        private const int AttackerDamageMultiplyer = 2;
        private const int AttackerHealthDivisor = 2;

        public void Execute(IBlob attacker, IBlob target)
        {
            var damageToAttacker = attacker.Health / AttackerHealthDivisor;
            attacker.TakeAttack(damageToAttacker);

            target.TakeAttack(attacker.Damage * AttackerDamageMultiplyer);
        }
    }
}
