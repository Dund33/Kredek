using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab5Homework.Models
{
    /// <summary>
    /// Class representing coal along with some basic properties
    /// </summary>
    public class CoalBasicViewModel
    {
        /// <summary>
        /// Coal ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Coal Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Amount of coal
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// Price of coal
        /// </summary>
        public decimal Price { get; set; }
    }
}
