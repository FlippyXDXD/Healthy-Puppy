   using BCrypt.Net;

   public static class PasswordHelper
   {
       // M�todo para hashear una contrase�a
       public static string HashPassword(string password)
       {
           return BCrypt.Net.BCrypt.HashPassword(password);
       }

       // M�todo para verificar una contrase�a
       public static bool VerifyPassword(string password, string hashedPassword)
       {
           return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
       }
   }
   