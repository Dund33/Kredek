using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Models.DTO
{
    public class GetFullCruiserDTO
    {
        public int ID { get; set; }
        public int Lasers { get; set; }
        public int PlasmaGuns { get; set; }
        public bool HasStarDrive { get; set; }
        public float TWR { get; set; }
        public float Isp { get; set; }
        public float Thrust { get; set; }
        public float Weight { get; set; }
    }
}
