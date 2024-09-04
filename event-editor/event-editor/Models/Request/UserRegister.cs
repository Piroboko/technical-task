namespace event_editor.Models.Request
{
    public class UserRegister
    {
        public string? Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string? Email { get; set; }
    }
}
