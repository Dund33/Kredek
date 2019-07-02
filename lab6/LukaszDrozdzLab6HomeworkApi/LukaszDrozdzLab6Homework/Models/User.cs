using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab6Homework.Models
{
    public class User
    {
        /// <summary>
        /// Username
        /// </summary>
        [Required]
        [Description("User name")]
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required]
        [Description("Password")]
        public string Password { get; set; }

        /// <summary>
        /// User's email
        /// </summary>
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Contructor for this class
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>

        public User(string userName, string password, string email)
        {
            Username = userName;
            Password = password;
            Email = email;
        }
    }
}
