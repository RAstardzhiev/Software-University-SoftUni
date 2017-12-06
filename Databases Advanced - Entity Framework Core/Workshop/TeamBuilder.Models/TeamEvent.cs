namespace TeamBuilder.Models
{
    public class TeamEvent
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
