namespace _02.Blobs.Entities.Behaviors
{
    using Interfaces;

    public class Inflated : Behavior
    {
        private const int TrigerHealthIncreasingUnits = 50;
        private const int HealthDecrementerPerTurn = 10;
        private const string InflatedInfluencingPropertyName = nameof(IBlob.Health);

        public Inflated() : base(InflatedInfluencingPropertyName)
        {
        }

        public override void ApplyRecurrentEffect(IBlob blob)
        {
            if (this.IsDelayNeeded)
            {
                this.IsDelayNeeded = false;
                return;
            }

            this.InfluencingProperty
                .SetValue(blob, blob.Health - HealthDecrementerPerTurn);
        }

        protected override void ApplyTriggerEffect(IBlob blob) => this.InfluencingProperty
            .SetValue(blob, blob.Health + TrigerHealthIncreasingUnits);
    }
}
