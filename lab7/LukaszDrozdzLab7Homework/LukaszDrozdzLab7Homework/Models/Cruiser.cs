using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Models
{
    public class Cruiser
    {
        /// <summary>
        /// Ship ID
        /// </summary>
        [Key]
        [Required]
        public int ID { get; set; }

        /// <summary>
        /// Number of onboard lasers
        /// </summary>
        [Required]
        public int Lasers { get; set; }

        /// <summary>
        /// Number of plasma guns
        /// </summary>
        [Required]
        public int PlasmaGuns { get; set; }

        /// <summary>
        /// Ship has StarDrive(R)
        /// </summary>
        [Required]
        public bool HasStarDrive { get; set; }

        /// <summary>
        /// Ship's thrust to weight ratio
        /// </summary>
        public float TWR { get; set; }

        /// <summary>
        /// Ships specific impulse
        /// </summary>
        public float Isp { get; set; }

        /// <summary>
        /// Ships thrust
        /// </summary>
        public float Thrust { get; set; }

        /// <summary>
        /// Ship weight
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Repairs
        /// </summary>
        public virtual List<CruiserRepair> Repairs { get; set; }

        /// <summary>
        /// Missions
        /// </summary>
        public virtual List<Mission> Missions { get; set; }
    }
}
