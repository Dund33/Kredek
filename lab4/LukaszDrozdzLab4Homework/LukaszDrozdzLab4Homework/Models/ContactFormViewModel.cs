using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab4Homework.Models
{
    public class ContactFormViewModel
    {
        /// <summary>
        /// User's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Users last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Message { get; set; }
    }
}
