using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Models.DTO
{
    public class GetBasicCruiserDTO
    {
        /// <summary>
        /// Cruiser ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Number of onboard lasers
        /// </summary>
        public int Lasers { get; set; }
        /// <summary>
        /// Number of onboard plasma guns
        /// </summary>
        public int PlasmaGuns { get; set; }
        /// <summary>
        /// Ship has StarDrive
        /// </summary>
        public bool HasStarDrive { get; set; }
    }
}
