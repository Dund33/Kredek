using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab6Api.Models
{
    public class Student
    {
        /// <summary>
        /// Student ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Students first name
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Students last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Age of the student
        /// </summary>
        public int Age { get; set; }


    }
}
