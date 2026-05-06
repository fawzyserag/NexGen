using Microsoft.AspNetCore.Mvc;
using LandingPageAPI.DTOs;
using LandingPageAPI.Services;

namespace LandingPageAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly ILogger<ContactController> _logger;

        public ContactController(
            IContactService contactService,
            ILogger<ContactController> logger)
        {
            _contactService = contactService;
            _logger = logger;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ContactResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Submit([FromBody] ContactMessageDto messageDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid contact form submission - ModelState errors");
                return BadRequest(new ContactResponseDto
                {
                    Success = false,
                    Message = "Invalid data provided. Please check all fields."
                });
            }

            var response = await _contactService.ProcessContactMessageAsync(messageDto);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
        }
    }
}
