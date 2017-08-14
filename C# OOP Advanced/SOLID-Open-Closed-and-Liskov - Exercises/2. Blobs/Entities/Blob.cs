namespace _02.Blobs.Entities
{
    using System;
    using Interfaces;

    public class Blob : IBlob
    {
        private readonly int healthTriggerPointForBehavior;

        private int health;
        private int initialHealth;
        private int initialDamage;

        public Blob(string name, int health, int damage, IBehavior behavior, IAttack attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Behavior = behavior;
            this.Attack = attack;

            this.initialHealth = health;
            this.initialDamage = damage;
            this.healthTriggerPointForBehavior = this.initialHealth / 2;
        }

        public string Name { get; private set; }

        public int Health
        {
            get
            {
                return this.health;
            }

            private set
            {
                this.health = value;

                if (this.health < 0)
                {
                    this.health = 0;
                }

                if (this.health <= this.healthTriggerPointForBehavior && !this.Behavior.IsTriggered)
                {
                    this.Behavior.Trigger(this);
                    this.IsTriggerMessageAvailable = true;
                }
            }
        }

        public int Damage { get; private set; }

        public IBehavior Behavior { get; private set; }

        public IAttack Attack { get; private set; }

        public bool IsTriggerMessageAvailable { get; set; }

        public void TakeAttack(int damage)
        {
            this.Health -= damage;
        }

        public void TriggerBehavior()
        {
            if (this.Behavior.IsTriggered)
            {
                throw new ArgumentException("Cannot triger more than once");
            }
            
            this.Behavior.Trigger(this);
        }

        public void MakeATurn()
        {
            if (this.Behavior.IsTriggered)
            {
                this.Behavior.ApplyRecurrentEffect(this);
            }
        }

        public override string ToString()
        {
            if (this.Health <= 0)
            {
                return $"Blob {this.Name} KILLED";
            }

            return $"Blob {this.Name}: {this.Health} HP, {this.Damage} Damage";
        }
    }
}