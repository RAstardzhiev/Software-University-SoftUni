namespace _02.Blobs.Entities.Behaviors
{
    using Interfaces;

    public class Aggressive : Behavior
    {
        private const int TrigerDamageMultiplier = 2;
        private const int DamageDecrementerPerTurn = 5;
        private const string AggressiveInfluencingPropertyName = nameof(IBlob.Damage);

        private int initialDamage;

        public Aggressive() : base(AggressiveInfluencingPropertyName)
        {
        }

        public override void ApplyRecurrentEffect(IBlob blob)
        {
            if (this.IsDelayNeeded)
            {
                this.IsDelayNeeded = false;
                return;
            }

            if (blob.Damage > this.initialDamage)
            {
                if (blob.Damage - DamageDecrementerPerTurn > this.initialDamage)
                {
                    this.InfluencingProperty
                        .SetValue(blob, (int)this.InfluencingProperty.GetValue(blob) - DamageDecrementerPerTurn);
                }
            }
        }

        protected override void ApplyTriggerEffect(IBlob blob)
        {
            this.initialDamage = blob.Damage - DamageDecrementerPerTurn;

            this.InfluencingProperty
                .SetValue(blob, (int)this.InfluencingProperty.GetValue(blob) * TrigerDamageMultiplier);
        }
    }
}