using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Models
{
    public class Destroyer
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
        /// Number of onboard beam trackers
        /// </summary>
        [Required]
        public int BeamTrackers { get; set; }

        /// <summary>
        /// Ships thrust to weight ratios
        /// </summary>
        public float TWR { get; set; }

        /// <summary>
        /// Ships specific impulse
        /// </summary>
        public float Isp { get; set; }

        /// <summary>
        /// Shps thrust
        /// </summary>
        public float Thrust { get; set; }

        /// <summary>
        /// Weight of the ship
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// List of repairs
        /// </summary>
        public virtual List<DestroyerRepair> Repairs { get; set; }

        /// <summary>
        /// List of missions
        /// </summary>
        public virtual List<Mission> Missions { get; set; }

    }
}
