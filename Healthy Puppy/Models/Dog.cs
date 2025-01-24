namespace Healthy_Puppy.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicializaci�n
        public string Breed { get; set; } = string.Empty; // Inicializaci�n
        public string Gender { get; set; } = string.Empty; // Inicializaci�n
        public int OwnerId { get; set; }
    }
}