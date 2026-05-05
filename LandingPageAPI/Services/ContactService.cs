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
                // Validate the message
                if (!ValidateContactMessage(messageDto))
                {
                    return new ContactResponseDto
                    {
                        Success = false,
                        Message = "Invalid contact message data"
                    };
                }

                // Map DTO to Model
                var contactMessage = ContactMessageMapper.ToModel(messageDto);

                // Log the contact submission
                _logger.LogInformation(
                    "Contact form submitted - Name: {Name}, Email: {Email}, Message Length: {Length}",
                    contactMessage.Name,
                    contactMessage.Email,
                    contactMessage.Message.Length
                );

                // Here you would typically:
                // 1. Save to database
                // 2. Send email notification
                // 3. Add to queue for processing
                // For now, we'll just simulate async operation
                await Task.Delay(100); // Simulate async work

                // Return success response
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

            // Additional validation
            if (messageDto.Name.Length < 2 || messageDto.Name.Length > 100)
                return false;

            if (messageDto.Message.Length < 10 || messageDto.Message.Length > 1000)
                return false;

            return true;
        }
    }
}
