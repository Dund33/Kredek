using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Models
{
    public class DestroyerRepair
    {

        /// <summary>
        /// Repair ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Repair description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Repair date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// ID of the ship
        /// </summary>
        [ForeignKey("ID")]
        public int ShipID { get; set; }

        /// <summary>
        /// Ship
        /// </summary>
        public Destroyer Ship { get; set; }
    }
}
