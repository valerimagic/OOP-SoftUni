using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DTO.ViewModels;


namespace DAL.Entiies
{
    public class User : BaseClass
    {
        //public User(string username, string password)//UserViewModel model)
        //{
        //    this.Username = username;
        //    this.Password = password;
        //    //this.Username = model.Username;
        //    //this.Password = model.Password;
        //}

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        public string Name { get; set; }

        public ICollection<Contacts> ContactID { get; set; } = new HashSet<Contacts>();

       

    }
}
