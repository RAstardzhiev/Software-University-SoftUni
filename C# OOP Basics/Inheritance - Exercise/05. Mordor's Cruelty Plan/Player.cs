namespace _05.Mordor_s_Cruelty_Plan
{
    using System;
    using System.Collections.Generic;
    using Factories.Foods;
    using Factories;
    using Factories.Moods;

    public class Player
    {
        private int HappinessPoints { get; set; }

        public Mood GetMentalCondition()
        {
            return MoodFactory.GetMood(this.HappinessPoints);
        }

        internal void Eat(IEnumerable<Food> foods)
        {
            foreach (var food in foods)
            {
                this.HappinessPoints += food.PointsOfHappiness;
            }
        }

        public override string ToString()
        {
            var mood = GetMentalCondition();
            return $"{this.HappinessPoints}{Environment.NewLine}{mood.GetType().Name}";
        }
    }
}
