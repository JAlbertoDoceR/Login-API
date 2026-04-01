using System;
using System.Collections.Generic;

namespace API_auth.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Correo { get; set; } = null!;

    public string Password { get; set; } = null!;
}
