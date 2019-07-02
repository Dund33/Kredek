using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7.Models.DTO
{
    public class GetStatisticJumperDTO
    {
        public int ID { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float PersonalBest { get; set; }

    }
}
