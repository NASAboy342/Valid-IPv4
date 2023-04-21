using CountryLibrary.Modal.Response;
using Microsoft.AspNetCore.Mvc;

namespace CountryLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController  : ControllerBase
    {
        [HttpGet]
        [Route("GetTeamMembers")]
        public IActionResult Get()
        {
            var Team = new TeamMembersResponse
            {
                Name = "Pin",
                Gender = "Male",
                Age = 23,
                Address = "National Road3",
                Email = "sopheakpin342@gmail.com"
            };
            return Ok(Team);
        }
    }
}
