using LandingPageAPI.DTOs;
using LandingPageAPI.Models;

namespace LandingPageAPI.Mappings
{
    public static class ContactMessageMapper
    {
        /// <summary>
        /// Maps ContactMessageDto to ContactMessage model
        /// </summary>
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

        /// <summary>
        /// Maps ContactMessage model to ContactMessageDto
        /// </summary>
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

        /// <summary>
        /// Maps a list of ContactMessage models to DTOs
        /// </summary>
        public static List<ContactMessageDto> ToDtoList(List<ContactMessage> models)
        {
            if (models == null)
                return new List<ContactMessageDto>();

            return models.Select(ToDto).ToList();
        }
    }
}
