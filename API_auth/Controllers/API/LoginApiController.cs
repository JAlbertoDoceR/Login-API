using API_auth.Models;
using API_auth.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API_auth.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginApiController : ControllerBase
    {
        private readonly LoginDbContext _context;

        public LoginApiController(LoginDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Correo == request.Correo && u.Password == request.Password);

            if (usuario == null)
            {
                return Unauthorized(new LoginResponse(false, "Credenciales incorrectas"));
            }

            return Ok(new LoginResponse(true, "¡Bienvenido!"));
        }
    }
}