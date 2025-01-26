   using BCrypt.Net;

   public static class PasswordHelper
   {
       // Método para hashear una contraseña
       public static string HashPassword(string password)
       {
           return BCrypt.Net.BCrypt.HashPassword(password);
       }

       // Método para verificar una contraseña
       public static bool VerifyPassword(string password, string hashedPassword)
       {
           return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
       }
   }
   