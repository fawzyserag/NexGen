namespace LandingPageAPI.DTOs
{
    public class ContactResponseDto
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime? SubmittedAt { get; set; }
    }
}
