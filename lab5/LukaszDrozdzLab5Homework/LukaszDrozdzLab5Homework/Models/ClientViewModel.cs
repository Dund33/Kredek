using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab5Homework.Models
{
    public class ClientViewModel
    {
        /// <summary>
        /// Clients unique ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Clients first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Clients last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Clients address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Clients PESEL
        /// </summary>
        public string PESEL { get; set; }
    }
}
