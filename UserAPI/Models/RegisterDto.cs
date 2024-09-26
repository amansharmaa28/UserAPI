namespace UserAPI.Models
{
    public class RegisterDto
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string? Admin { get; set; }
    }

}
