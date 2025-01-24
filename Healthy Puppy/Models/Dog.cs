namespace Healthy_Puppy.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicialización
        public string Breed { get; set; } = string.Empty; // Inicialización
        public string Gender { get; set; } = string.Empty; // Inicialización
        public int OwnerId { get; set; }
    }
}