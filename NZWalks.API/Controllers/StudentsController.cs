using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var studentNames = new string[] { "John", "Elena", "Mirabella", "Peter", "Elisabet" };
            return Ok(studentNames);
        }
    }
}
