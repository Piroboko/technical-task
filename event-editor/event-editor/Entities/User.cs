namespace event_editor.Models
{
    public class User
    {

        public int Id { get; set; }

        public string? Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string? Email { get; set; }

        public ICollection<UserEvent> UserEvents { get; set; }
    }
}
