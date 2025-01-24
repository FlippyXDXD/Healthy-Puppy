using SQLite;
using Healthy_Puppy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Healthy_Puppy.Data
{
    public class AppDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        // Constructor que inicializa la conexión con la base de datos
        public AppDatabase(string dbPath)
        {
            // Conecta a la base de datos
            _database = new SQLiteAsyncConnection(dbPath);

            // Crea las tablas si no existen
            _database.CreateTableAsync<Owner>().Wait();
            _database.CreateTableAsync<Dog>().Wait();
        }

        // ---- Operaciones CRUD para la tabla "owners" ----

        // Guardar un nuevo dueño
        public Task<int> SaveOwnerAsync(Owner owner)
        {
            return _database.InsertAsync(owner);
        }

        // Obtener todos los dueños
        public Task<List<Owner>> GetOwnersAsync()
        {
            return _database.Table<Owner>().ToListAsync();
        }

        // Obtener un dueño por su ID
        public Task<Owner> GetOwnerByIdAsync(int id)
        {
            return _database.Table<Owner>().Where(o => o.Id == id).FirstOrDefaultAsync();
        }

        // Eliminar un dueño
        public Task<int> DeleteOwnerAsync(Owner owner)
        {
            return _database.DeleteAsync(owner);
        }

        // ---- Operaciones CRUD para la tabla "dogs" ----

        // Guardar un nuevo perro
        public Task<int> SaveDogAsync(Dog dog)
        {
            return _database.InsertAsync(dog);
        }

        // Obtener todos los perros
        public Task<List<Dog>> GetDogsAsync()
        {
            return _database.Table<Dog>().ToListAsync();
        }

        // Obtener un perro por su ID
        public Task<Dog> GetDogByIdAsync(int id)
        {
            return _database.Table<Dog>().Where(d => d.Id == id).FirstOrDefaultAsync();
        }

        // Eliminar un perro
        public Task<int> DeleteDogAsync(Dog dog)
        {
            return _database.DeleteAsync(dog);
        }
    }
}
