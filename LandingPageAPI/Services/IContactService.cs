using LandingPageAPI.DTOs;

namespace LandingPageAPI.Services
{
    public interface IContactService
    {
        Task<ContactResponseDto> ProcessContactMessageAsync(ContactMessageDto messageDto);
        bool ValidateContactMessage(ContactMessageDto messageDto);
    }
}
