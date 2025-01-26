using System.Collections.Generic;

namespace Healthy_Puppy.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicialización para evitar CS8618
        public string Phone { get; set; } = string.Empty; // Inicialización
        public string Email { get; set; } = string.Empty; // Inicialización
        public string PasswordHash { get; set; } = string.Empty; // Inicialización para la contraseña hasheada
    }
}