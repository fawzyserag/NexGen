using LandingPageAPI.DTOs;
using LandingPageAPI.Models;
using LandingPageAPI.Mappings;

namespace LandingPageAPI.Services
{
    public class ContactService : IContactService
    {
        private readonly ILogger<ContactService> _logger;

        public ContactService(ILogger<ContactService> logger)
        {
            _logger = logger;
        }

        public async Task<ContactResponseDto> ProcessContactMessageAsync(ContactMessageDto messageDto)
        {
            try
            {
                if (!ValidateContactMessage(messageDto))
                {
                    return new ContactResponseDto
                    {
                        Success = false,
                        Message = "Invalid contact message data"
                    };
                }

                var contactMessage = ContactMessageMapper.ToModel(messageDto);

                _logger.LogInformation(
                    "Contact form submitted - Name: {Name}, Email: {Email}, Message Length: {Length}",
                    contactMessage.Name,
                    contactMessage.Email,
                    contactMessage.Message.Length
                );

                await Task.Delay(100); 

                return new ContactResponseDto
                {
                    Success = true,
                    Message = "Thank you for contacting us! We'll get back to you soon.",
                    SubmittedAt = DateTime.UtcNow
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing contact message from {Email}", messageDto.Email);
                
                return new ContactResponseDto
                {
                    Success = false,
                    Message = "An error occurred while processing your message. Please try again later."
                };
            }
        }

        public bool ValidateContactMessage(ContactMessageDto messageDto)
        {
            if (messageDto == null)
                return false;

            if (string.IsNullOrWhiteSpace(messageDto.Name))
                return false;

            if (string.IsNullOrWhiteSpace(messageDto.Email))
                return false;

            if (string.IsNullOrWhiteSpace(messageDto.Message))
                return false;

            if (messageDto.Name.Length < 2 || messageDto.Name.Length > 100)
                return false;

            if (messageDto.Message.Length < 10 || messageDto.Message.Length > 1000)
                return false;

            return true;
        }
    }
}
