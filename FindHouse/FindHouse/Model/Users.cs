using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHouse.Model
{
   public class Users
   {
        [PrimaryKey, AutoIncrement]
        public int      Id { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }

   }
}
