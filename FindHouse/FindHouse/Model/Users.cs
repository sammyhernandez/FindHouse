using SQLite;
using System.Collections.Generic;

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

            if (string.IsNullOrWhiteSpace(FirstName)) errors.Add("FirstName is required");
            if (string.IsNullOrWhiteSpace(LastName)) errors.Add("LastName is required");
            if (string.IsNullOrWhiteSpace(Email)) errors.Add("Email is required");

            return errors;
        }
        public List<string> ValidatePassword(string passConfirm)
        {
            var errors = new List<string>();
             
            if (string.IsNullOrWhiteSpace(Password)) errors.Add("Password is required");
            if (string.IsNullOrWhiteSpace(passConfirm)) errors.Add("PasswordConfirm is required");
            if (!string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(passConfirm) 
                && passConfirm != Password) errors.Add("Password y PasswordConfirm deben se iguale");

            return errors;
        }

    }
}
