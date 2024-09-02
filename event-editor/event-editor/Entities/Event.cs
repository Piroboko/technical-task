namespace event_editor.Models
{
    public class Event
    {

        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateOnly DateTime { get; set; }

        public string? Category { get; set; }

        public int MaxParticipants { get; set; }

        public string? Image { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<UserEvent> UserEvents { get; set; }
    }
}
