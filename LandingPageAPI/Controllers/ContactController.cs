using Microsoft.AspNetCore.Mvc;
using LandingPageAPI.Models;

namespace LandingPageAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Submit([FromBody] ContactMessage message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { success = false, message = "Invalid data provided" });
            }

            if (string.IsNullOrWhiteSpace(message.Name) || 
                string.IsNullOrWhiteSpace(message.Email) || 
                string.IsNullOrWhiteSpace(message.Message))
            {
                return BadRequest(new { success = false, message = "All fields are required" });
            }

            _logger.LogInformation($"Contact form submitted - Name: {message.Name}, Email: {message.Email}");

            return Ok(new { 
                success = true, 
                message = "Thank you for contacting us! We'll get back to you soon." 
            });
        }
    }
}
