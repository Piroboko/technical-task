using AutoMapper;
using event_editor.Data;
using event_editor.Entities;
using event_editor.Models.Request;
using event_editor.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace event_editor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;
        private readonly AppDbContext _context;

        public AuthController(IMapper mapper, IAuthService authService, AppDbContext context)
        {
            _mapper = mapper;
            _authService = authService;
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register([FromBody] UserRegister userRegister)
        {
            var user = _mapper.Map<User>(userRegister);

            return Ok(user);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();

            return Ok(users);
        }
    }
}
