namespace _02.Blobs.Entities.Behaviors
{
    using System;
    using System.Reflection;
    using Interfaces;

    public abstract class Behavior : IBehavior
    {
        private const string ExceptionMessage = "Behavior can be triggered only once";

        public Behavior(string influencingPropertyName)
        {
            this.IsDelayNeeded = true;
            this.InfluencingProperty = typeof(Blob)
                .GetProperty(influencingPropertyName);
        }

        public bool IsTriggered { get; protected set; }

        public bool IsDelayNeeded { get; protected set; }

        protected PropertyInfo InfluencingProperty { get; private set; }

        public abstract void ApplyRecurrentEffect(IBlob blob);

        public void Trigger(IBlob blob)
        {
            if (blob.Behavior.IsTriggered)
            {
                throw new InvalidOperationException(ExceptionMessage);
            }

            this.IsTriggered = true;
            this.ApplyTriggerEffect(blob);
        }

        protected abstract void ApplyTriggerEffect(IBlob blob);
    }
}