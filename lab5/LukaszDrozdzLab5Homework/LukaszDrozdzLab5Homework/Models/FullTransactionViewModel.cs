using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab5Homework.Models
{
    public class FullTransactionViewModel
    {
        /// <summary>
        /// Name of coal being sold
        /// </summary>
        public string CoalName { get; set; }
        /// <summary>
        /// PESEL of the buyer
        /// </summary>
        public string PESEL { get; set; }
        /// <summary>
        /// Invoice ID
        /// </summary>
        public int DocumentID { get; set; }
        /// <summary>
        /// Buyers first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Buyers last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Amount of coal being sold
        /// </summary>
        public double AmountOfCoal { get; set; }
        /// <summary>
        /// Calculated tax
        /// </summary>
        public decimal Tax { get; set; }
        /// <summary>
        /// Cost without tax
        /// </summary>
        public decimal Cost { get; set; }
    }
}
