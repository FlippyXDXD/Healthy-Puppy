using System.Collections.Generic;

namespace Healthy_Puppy.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicializaci�n para evitar CS8618
        public string Phone { get; set; } = string.Empty; // Inicializaci�n
        public string Email { get; set; } = string.Empty; // Inicializaci�n
        public List<Dog> Dogs { get; set; } = new(); // Inicializaci�n como lista vac�a
    }
}