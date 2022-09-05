using System;
using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Usuario
    {
        public string DniUsu { get; set; } = null!;
        public string NombreUsu { get; set; } = null!;
        public string ContraseñaUsu { get; set; } = null!;
        public string ApellidoUsu { get; set; } = null!;
        public string CorreoUsu { get; set; } = null!;
        public string? CelularUsu { get; set; }
    }
}
