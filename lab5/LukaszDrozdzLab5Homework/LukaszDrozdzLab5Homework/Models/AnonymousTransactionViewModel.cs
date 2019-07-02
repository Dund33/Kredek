using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab5Homework.Models
{
    /// <summary>
    /// Class representing a transaction
    /// </summary>
    public class AnonymousTransactionViewModel
    {
        /// <summary>
        /// Clients first name
        /// </summary>
        public string ClientFirstName { get; set; }
        /// <summary>
        /// Cients last name
        /// </summary>
        public string ClientLastName { get; set; }
        /// <summary>
        /// Clients PESEL
        /// </summary>
        public string PESEL { get; set; }
        /// <summary>
        /// Clients address
        /// </summary>
        public string ClientAddress { get; set; }
        /// <summary>
        /// Coal id
        /// </summary>
        public int CoalID { get; set; }
        /// <summary>
        /// Amount of coal
        /// </summary>
        public double AmountOfCoal { get; set; }
        /// <summary>
        /// Total cost
        /// </summary>
        public decimal Cost { get; set; }
        /// <summary>
        /// Total tax
        /// </summary>
        public decimal Tax { get; set; }
        /// <summary>
        /// Invoice ID
        /// </summary>
        public string DocumentID { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }
    }
}
