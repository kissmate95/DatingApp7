using System.Data;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // GET /api/users

    public class UsersController : ControllerBase
    {
        private readonly DataContex _contex;
        public UsersController(DataContex contex)
        {
            _contex = contex;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _contex.Users.ToListAsync();

            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _contex.Users.FindAsync(id);
        }

        
    }
}