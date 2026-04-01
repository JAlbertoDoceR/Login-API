using System.ComponentModel.DataAnnotations;

namespace API_auth.Models.DTO
{ 
    public record LoginResponse(
        bool Exito,
        string Mensaje   
    );
}
