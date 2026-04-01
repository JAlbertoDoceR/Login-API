using System.ComponentModel.DataAnnotations;

namespace API_auth.Models.DTO
{
    public record LoginRequest(
        [Required(ErrorMessage = "El correo es obligatorio"), EmailAddress] string Correo,
        [Required(ErrorMessage = "La contraseña es obligatoria")] string Password
    );
}