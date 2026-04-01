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

        // POST: api/LoginApi/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Correo == request.Correo && u.Password == request.Password);

            if (usuario == null)
            {
                // Usamos el DTO para el error
                return Unauthorized(new LoginResponse(false, "Credenciales incorrectas"));
            }

            // Usamos el DTO para el éxito
            return Ok(new LoginResponse(true, "¡Bienvenido!"));
        }
    }
}