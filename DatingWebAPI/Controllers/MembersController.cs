using DatingWebAPI.Data;
using DatingWebAPI.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly AppDbContext context;

        public MembersController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("GetallMembers")]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetallMembers()
        {
            var members = await context.Users.AsNoTracking().ToListAsync();

            return Ok(members);
        }

        [Authorize]
        [HttpGet("GetmemberByID/{id}")]
        public async Task<ActionResult<AppUser>> GetmemberByID(string id)
        {
            var member = await context.Users.FindAsync(id);

            if (member == null) return NotFound();

            return Ok(member);
        }
    }
}