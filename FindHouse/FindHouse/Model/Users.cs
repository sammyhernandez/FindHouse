using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FindHouse.Model
{
    public class Users
    {
        public string Id { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }

        public List<string> ValidateUser()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(FirstName)) errors.Add("Nombre Requerido");
            if (string.IsNullOrWhiteSpace(LastName)) errors.Add("Apellido Requerido");
            if (string.IsNullOrWhiteSpace(Email)) errors.Add("Correo Electrónico Requerido");

            return errors;
        }
        public List<string> ValidatePassword(string passConfirm)
        {
            var errors = new List<string>();
             
            if (string.IsNullOrWhiteSpace(Password)) errors.Add("Contraseña Requerida");
            if (string.IsNullOrWhiteSpace(passConfirm)) errors.Add("Confirmacion de contraseña Requerida");
            if (!string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(passConfirm) 
                && passConfirm != Password) errors.Add("Contraseña y Confirmacion de contraseña deben se iguales");

            return errors;
        }

        public List<string> ValidateEmail(string Email)
        {

            
            var correoFailed = new List<string>();
            var email = App.mobileServer.GetTable<Users>();

            if (email.Equals(Email)) correoFailed.Add("Este correo ya esta registrado.");

            return correoFailed;
        }

    }
}
