namespace _05.Mordor_s_Cruelty_Plan.Factories
{
    using Moods;

    public class MoodFactory
    {
        public static Mood GetMood(int happinessPoints)
        {
            if (happinessPoints < -5)
            {
                return new Angry(happinessPoints);
            }
            else if (happinessPoints <= 0)
            {
                return new Sad(happinessPoints);
            }
            else if (happinessPoints <= 15)
            {
                return new Happy(happinessPoints);
            }
            else
            {
                return new JavaScript(happinessPoints);
            }
        }
    }
}
