using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public float Record { get; set; }

        public virtual List<Jumper> Jumpers { get; set; }
    }
}
