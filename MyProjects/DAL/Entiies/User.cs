using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entiies
{
    public class User
        :BaseClass
    {
       
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        public ICollection<Contacts> ContactID { get; set; } = new HashSet<Contacts>();
    }
}
