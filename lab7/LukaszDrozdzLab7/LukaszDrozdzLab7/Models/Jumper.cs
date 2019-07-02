using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7.Models
{
    public class Jumper
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float PersonalBest { get; set; }

        [ForeignKey("CountryID")]
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
