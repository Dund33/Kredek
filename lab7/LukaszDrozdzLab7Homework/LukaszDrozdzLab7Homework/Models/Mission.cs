using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Models
{
    public class Mission
    {
        /// <summary>
        /// Mision ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Ship ID
        /// </summary>
        [ForeignKey("ID")]
        public int ShipID { get; set; }

        /// <summary>
        /// Mission description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Mission date
        /// </summary>
        public DateTime Date { get; set; }
    }
}
