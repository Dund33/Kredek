using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab5Homework.Models
{
    /// <summary>
    /// Class representing delivery
    /// </summary>
    public class DeliveryViewModel
    {
        /// <summary>
        /// ID of coal being delivered
        /// </summary>
        public int CoalID { get; set; }
        /// <summary>
        /// Amount of coal being delivered
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
