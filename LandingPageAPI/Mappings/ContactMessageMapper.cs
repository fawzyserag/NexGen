using LandingPageAPI.DTOs;
using LandingPageAPI.Models;

namespace LandingPageAPI.Mappings
{
    public static class ContactMessageMapper
    {
        public static ContactMessage ToModel(ContactMessageDto dto)
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            return new ContactMessage
            {
                Name = dto.Name?.Trim() ?? string.Empty,
                Email = dto.Email?.Trim().ToLower() ?? string.Empty,
                Message = dto.Message?.Trim() ?? string.Empty
            };
        }

        public static ContactMessageDto ToDto(ContactMessage model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            return new ContactMessageDto
            {
                Name = model.Name,
                Email = model.Email,
                Message = model.Message
            };
        }

        public static List<ContactMessageDto> ToDtoList(List<ContactMessage> models)
        {
            if (models == null)
                return new List<ContactMessageDto>();

            return models.Select(ToDto).ToList();
        }
    }
}
